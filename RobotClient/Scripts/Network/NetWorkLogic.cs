using System;
using System.Threading.Tasks;
using UnityEngine;
using LiteNet;
using ProtobufPacket;
using Games.GlobeDefine;

public partial class NetworkLogic
{
    public string _ip = "127.0.0.1";
    public int _port = 30022;

    // 网络连接
    private LiteNet.Network network = null;

    //供外部注册进来的回调
    public delegate void OnConnect(bool bSuccess);
    public delegate void OnClose();
    public OnConnect onConnectServer = null;
    public OnClose onClosed = null;

    public Robot robot = null;

    #region 网络操作接口
    public NetworkLogic(Robot _robot)
    {
        robot = _robot;
    }

    public void Release()
    {
        // 关闭同时销毁连接
        Close();

        // 清除回调
        onConnectServer = null;
        onClosed = null;
    }

    public void Update()
    {
        // 更新网络状态
        if (robot != null && network != null)
        {
            network.Update(robot);
        }
    }

    public void Connect(string ip, int port)
    {
        // 关闭原网络连接
        if (network != null)
        {

            GameLog.LogErrorFormat("wltest: Connect. close old conn. {0}", State);
            Close();
        }

        _ip = ip;
        _port = port;

        DoConnectToServer();
    }

    private void DoConnectToServer()
    {
        // 配置网络连接
        ConnectionConfiguration config = new ConnectionConfiguration(_ip, _port);
        config.onConnected = OnConnected;
        config.onClosed = OnClosed;
        config.onError = OnError;

        // 发起网络连接
        network = new LiteNet.Network();
        network.Open(config);
    }

    public void Close()
    {
        if (network != null)
        {
            network.Close();
            network.OnDestroy();
            network = null;
        }
    }

    public void Pause()
    {

    }

    public void Resume()
    {

    }

    public string Ip
    {
        get { return _ip; }
    }
    public int Port
    {
        get { return _port; }
    }

    public ConnectionState State
    {
        get
        {
            if (network != null)
            {
                return network.ConnectionState;
            }
            return ConnectionState.None;
        }
    }

    // 网络状态回调-连接成功
    private void OnConnected()
    {
        robot.Log("GameNet connected.");
        robot.IsConnected = true;
    }

    // 网络状态回调-关闭
    private void OnClosed()
    {
        robot.LogError("GameNet closed.");
        if (onClosed != null)
        {
            onClosed();
        }
        robot.IsConnected = false;
    }

    // 网络状态回调-异常
    private void OnError()
    {
        robot.LogError("GameNet error. 进入重连StateExit, 准备重连");
        if (onConnectServer != null)
        {
            onConnectServer(false);
            onConnectServer = null;
        }

        //重连
        robot.IsConnected = false;
        robot.FSM.ChangeState(new StateExit());
    }
    #endregion

    #region 网络消息接口
    public void SendMsg(IMessage message)
    {
        if (network == null)
        {
            GameLog.LogWarning("GameNet.SendMsg network null.");
            return;
        }

        if (State == ConnectionState.Connected)
        {
            network.Send(robot, message);
        }
        else
        {
            GameLog.LogError("GameNet.SendMsg connection state error." + network);
        }
    }
    #endregion

    #region 特殊消息包

    public void OnSession(int session)
    {
        //获得服务器session链接后，发包收包会用 sessionKey 进行编码
        network.SetKey(session);
        // 获得session而不是连接成功，所以回调放在这里处理
        if (onConnectServer != null)
        {
            onConnectServer(true);
            onConnectServer = null;
        }
    }

    public void OnHeartbeat(long ansiTime)
    {
        ServerTime.UpdateServerTime(ansiTime);
        SendMsg(new XX_RESPONSE_HEARTBEAT());
    }
    public override string ToString()
    {
        return (network != null) ? network.ToString() : "network null";
    }
    #endregion
}
