using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace LiteNet
{
    [SLua.CustomLuaClass]
    public delegate void OnConnected();
    [SLua.CustomLuaClass]
    public delegate void OnClosed();
    [SLua.CustomLuaClass]
    public delegate void OnError();

    public sealed class ConnectionConfiguration
    {
        public IPEndPoint endpoint = null;

        internal int sendBufferSize = 0;
        internal Queue<Package> sendQueue = null;

        internal int recvBufferSize = 0;
        internal Queue<Package> recvQueue = null;

        public OnConnected onConnected = null;
        public OnClosed onClosed = null;
        public OnError onError = null;

        public ConnectionConfiguration(
            string address,
            int port,
            int sendBufferSize = 1024 * 1024,
            int recvBufferSize = 8192)
        {
            endpoint = new IPEndPoint(IPAddress.Parse(address), port);
            this.sendBufferSize = sendBufferSize;
            this.recvBufferSize = recvBufferSize;
        }
    }

    public enum ConnectionState
    {
        None,
        Connecting,
        Connected,
        Error,
        Closed,
    }

    internal sealed class Connection
    {
        private static int incId = 0;

        private int cid = 0;
        public int Id { get { return cid; } }

        private byte[] key = null;
        public byte[] Key { set { key = value; } }

        private Socket socket = null;
        //当前网络连接状态
        ConnectionState state = ConnectionState.None;
        public ConnectionState State
        {
            get { return state; }
        }

        //后续的网络状态，用于异步方式通知
        ConnectionState nextState = ConnectionState.None;
        //状态消息，用于异步方式通知
        private string nextStateMsg = null;

        // 发送缓存区
        Queue<Package> m_SendQueue = null;
        MemoryStream m_EncodeMemory = new MemoryStream(4096);

        // 接收缓存区
        ChannelBufferLite m_RecvBuf = new ChannelBufferLite();
        MemoryStream m_DecodeMemory = new MemoryStream(4096);
        Queue<Package> m_RecvQueue = null;

        public OnConnected onConnected = null;
        public OnClosed onClosed = null;
        public OnError onError = null;

        public bool CanSend
        {
            get {
                return state == ConnectionState.Connected && nextState == ConnectionState.None;
            }
        }

        Connection()
        {
            cid = incId++;
        }

        public static Connection Open(ConnectionConfiguration config)
        {
            
            Connection c = new Connection();
            c.m_SendQueue = config.sendQueue;
            c.m_RecvQueue = config.recvQueue;
            c.onConnected = config.onConnected;
            c.onClosed = config.onClosed;
            c.onError = config.onError;

            try {
                c.socket = new Socket(config.endpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                c.socket.SendBufferSize = config.sendBufferSize;
                c.socket.ReceiveBufferSize = config.recvBufferSize;
                c.socket.NoDelay = true;
                c.socket.LingerState = new LingerOption(true, 0);
                c.socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true); //允许套接字绑定到已在使用中的地址。

                c.state = ConnectionState.Connecting;
                c.nextState = ConnectionState.None;
                c.nextStateMsg = null;
                IAsyncResult ar=c.socket.BeginConnect(config.endpoint, c.ConnectCallback, null);
                //60秒还没有链接到服务器，就抛出异常
                bool success = ar.AsyncWaitHandle.WaitOne(60000);
                if (!success)
                {
                    throw new Exception("socket session 60秒超时时间已到，未连接到指定服务器" + config.endpoint.Address + ":" + config.endpoint.Port);
                }
            } catch (Exception e) {
                c.nextState = ConnectionState.Error;
                c.nextStateMsg = e.ToString();
                GameLog.LogError("--- socket session Open exception ----" + e.ToString());
            }
            return c;
        }

        //在异步线程内调用，不要直接调用任何逻辑代码（包括Unity接口，避免跨线程问题）
        void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                socket.EndConnect(ar);
                // 异步方式记录，避免跨线程问题
                nextState = ConnectionState.Connected;
                nextStateMsg = null;
                GameLog.Log("--- socket session ConnectCallback 正常");
            } catch (Exception e) {
                nextState = ConnectionState.Error;
                nextStateMsg = e.ToString();
                GameLog.LogError("--- socket session ConnectCallback 异常 ---- " + e.ToString());
            }
        }

        // 主动断开网络连接
        public void Disconnect()
        {
            Close();
        }

        // 必须由主线程调用，避免跨线程问题
        public void UpdateNextState()
        {
            // 处理BeginConnect回调中的异步数据
            if (nextState != ConnectionState.None) {
                if (nextState == ConnectionState.Connected) {
                    ConnectEstablished();
                } else {
                    GameLog.LogError("---非Connected状态中:  UpdateNextState:  " + nextStateMsg);
                    ConnectLost(nextState, nextStateMsg);
                }
            }

            // 以同步方式处理消息
            if (state == ConnectionState.Connected) {
                //向服务器发送消息包
                ProcessOutput();

                //解析处理 收到的服务器消息包
                ProcessInput();
            }
        }

        public void Send(ref Package package)
        {
            m_SendQueue.Enqueue(package);
        }

        //发送消息包 到服务器
        void ProcessOutput()
        {
            if (socket == null) {
                return;
            }

            try {
                while (m_SendQueue.Count > 0) {
                    Package package = m_SendQueue.Dequeue();
                    m_EncodeMemory.Position = 0;
                    Codec.Encode(ref package, key, m_EncodeMemory);

                    byte[] buffer = m_EncodeMemory.GetBuffer();
                    int offset = 0;
                    int size = (int)m_EncodeMemory.Position;
                    while (size > 0) {
                        int bytesSent = socket.Send(buffer, offset, size, SocketFlags.None);
                        if (bytesSent <= 0) {
                            ConnectLost(ConnectionState.Error, "output error. socket.Send fail.");
                            break;
                        } else {
                            offset += bytesSent;
                            size -= bytesSent;
                        }
                    }
                }
            } catch (Exception ex) {
                ConnectLost(ConnectionState.Error, "output error."+ex.ToString());
            }
        }

        //处理从服务器 收到的消息包
        void ProcessInput()
        {
            if (socket == null || !socket.Poll(0, SelectMode.SelectRead)) {
                return;
            }
            try {
                byte[] buf = new byte[socket.ReceiveBufferSize];
                int size = socket.Receive(buf);
                if (size <= 0) {
                    //收到的服务器消息包为空  不能代表链接异常
                    //ConnectLost(ConnectionState.Error, "input error.receive size:" + size);
                } else {
                    m_RecvBuf.Write(buf, size);
                    ExtractMessages();
                }
            } catch (Exception e) {
                ConnectLost(ConnectionState.Error, "ReceiveBufferSize: " + socket.ReceiveBufferSize + ". input error. " + e.ToString());
            }
        }

        private void ExtractMessages()
        {
            while (true) {
                int offset, size;
                byte[] buffer = m_RecvBuf.GetBuffer(out offset, out size);
                int length;
                if (!Header.Peek(buffer, offset, size, out length))
                    break;

                try {
                    m_DecodeMemory.Position = 0;
                    m_DecodeMemory.SetLength(0);
                    m_DecodeMemory.Write(buffer, offset, size);
                    m_DecodeMemory.Position = 0;

                    Package package = Codec.Decode(key, m_DecodeMemory);
                    m_RecvQueue.Enqueue(package);
                } catch (Exception e) {
                    GameLog.LogErrorFormat("#Conn{0} Exception: {1}", cid, e.Message);
                    GameLog.LogException(e);
                }
                m_RecvBuf.Consume(length);
            }
        }

        private void ConnectEstablished()
        {
            if (onConnected != null) {
                onConnected();
            }
            state = nextState;
            nextState = ConnectionState.None;
            nextStateMsg = null;

        }

        private void ConnectLost(ConnectionState nState, string sMsg = null)
        {
            GameLog.LogError("---socket session ConnectLost, nState:" + nState + " ,  sMsg:" + sMsg);
            if (nState == ConnectionState.Closed) {
                if (onClosed != null) {
                    onClosed();
                }
            } else {
                //onError 状态，会进入 stateExit，最终结果会触发重新链接 session
                if (onError != null) {
                    onError();
                }
            }
            Close();
        }

        // 不要直接调用，请使用ConnectLost
        private void Close()
        {
            if (null != socket) {
                try {
                    socket.Shutdown(SocketShutdown.Both);
                } catch (Exception ex) {
                    GameLog.LogErrorFormat("Con {0} shutdown failed. ex: {1}", cid,ex.ToString());
                }
                socket.Close();
                socket = null;
            }

            // 清理缓冲区
            m_SendQueue.Clear();
            m_EncodeMemory.Close();

            m_RecvBuf.Clear();
            m_DecodeMemory.Close();
            m_RecvQueue.Clear();

            // 清理回调
            onConnected = null;
            onError = null;
            onClosed = null;

            // 重置状态
            state = ConnectionState.Closed;
            nextState = ConnectionState.None;
            nextStateMsg = null;
        }

        public override string ToString()
        {
            return string.Format("state({0}) sendQueue({1}) recvQueue({2})",
                state, m_SendQueue.Count, m_RecvQueue.Count);
        }
    }
}