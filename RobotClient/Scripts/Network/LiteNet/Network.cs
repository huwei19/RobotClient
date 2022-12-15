using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-CSharp-Editor")]

namespace LiteNet
{
    public sealed class Network
    {
        ushort packageSeq = 0;
        Connection connection;
        Queue<Package> sendQueue = new Queue<Package>();
        Queue<Package> recvQueue = new Queue<Package>();

        public IPEndPoint EndPoint { get; private set; }
        public ConnectionState ConnectionState { get { return null != connection ? connection.State : ConnectionState.None; } }

        public static void Init()
        {
            MessageCodecCollection.Init();
            MessageMapping.Init();
            MessageHandlerCollection.Init();
        }

        public void OnDestroy()
        {
            if (null != connection){
                GameLog.Log(" ---- connection 断开链接 OnDestroy --- ");
                connection.Disconnect();
            }
        }

        public void Update(Robot robot)
        {
            if (connection != null) {
                connection.UpdateNextState();
                ProcessMessages(robot);
            }
        }

        public void Open(ConnectionConfiguration config)
        {
            if (null != connection) {
                GameLog.Log(" ---- connection 链接Open时关闭 --- ");
                connection.Disconnect();
                connection = null;
            }

            // 每次都重新创建新的Connection
            EndPoint = config.endpoint;
            config.sendQueue = sendQueue;
            config.recvQueue = recvQueue;
            connection = Connection.Open(config);
        }

        public void Close()
        {
            if (null != connection)
            {
                GameLog.Log(" ---- connection 断开链接 Close --- ");
                connection.Disconnect();
                connection = null;
            }
            packageSeq = 0;
        }

        public void SetKey(int value)
        {
            if (null != connection)
                connection.Key = Encoding.ASCII.GetBytes(value.ToString());
            else
                GameLog.LogError("No connection to set key to");
        }

        public void Send(Robot robot, IMessage message)
        {
            MessageID messageId = MessageMapping.GetMessageID(message.GetType());
            if (messageId == MessageID.None) {
                robot.LogErrorFormat("{0} doesn't have message id", message.GetType());
                return;
            }

            Package package = new Package();
            package.header.msg = (short)messageId;
            package.message = message;
            Send(robot, ref package);
            robot.Log(string.Format("<color=yellow>{0}</color>", "发送消息包：" + message));
        }

        internal void Send(Robot robot, ref Package package)
        {
            package.header.seq = (short)(packageSeq++);
            if (null != connection)
                connection.Send(ref package);
            else
                sendQueue.Enqueue(package);

            StatisticLogic.OnSendMessage(robot, ref package);
        }

        private void ProcessMessages(Robot robot)
        {
            Package package;
            while (recvQueue.Count > 0)
            {
                package = recvQueue.Dequeue();
                robot.Log(string.Format("<color=yellow>{0}</color>", "接收消息包：" + (MessageID)package.header.msg));
                MessageHandlerCollection.Invoke(robot, ref package);
                StatisticLogic.OnReceiveMessage(robot, ref package);
            }
        }

        public override string ToString()
        {
            return (connection != null) ? connection.ToString() : "connection null";
        }
    }
}
