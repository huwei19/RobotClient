using System;
using System.Reflection;
using System.Collections.Generic;

namespace LiteNet
{
    internal static class MessageHandlerCollection
    {
        static Dictionary<short, IMessageHandler> defaultHandlers = new Dictionary<short, IMessageHandler>();
        static Dictionary<short, List<IMessageHandler>> subscribeHandlers = new Dictionary<short, List<IMessageHandler>>();

        public static void Init()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            if (assembly == null) {
                return;
            }

            foreach (var type in assembly.ExportedTypes)
            {
                var attr = type.GetCustomAttribute<MessageHandlerAttribute>();
                if (null != attr)
                {
                    MessageID messageId = attr.messageId;
                    if (defaultHandlers.ContainsKey((short)messageId))
                    {
                        GameLog.LogWarningFormat("messageId({0}) already has a MessageHandler, ignore({1})", messageId, type);
                        continue;
                    }

                    if (typeof(IMessageHandler).IsAssignableFrom(type))
                    {
                        defaultHandlers.Add(
                            (short)messageId,
                            (IMessageHandler)Activator.CreateInstance(type));
                    }
                }
            }
        }

        public static void Subscribe(MessageID messageId, IMessageHandler handler)
        {
            List<IMessageHandler> list;
            if (!subscribeHandlers.TryGetValue((short)messageId, out list))
            {
                list = new List<IMessageHandler>();
                subscribeHandlers.Add((short)messageId, list);
            }
            list.Add(handler);
        }

        public static void Unsubscribe(MessageID messageId, IMessageHandler handler)
        {
            List<IMessageHandler> list;
            if (subscribeHandlers.TryGetValue((short)messageId, out list))
                list.Remove(handler);
        }

        public static void Invoke(Robot robot, ref Package package)
        {
            short messageId = package.header.msg;
            List<IMessageHandler> list;
            if (subscribeHandlers.TryGetValue(messageId, out list))
            {
                for (int i = 0; i < list.Count; ++i)
                    ExecuteHandler(robot, list[i], ref package);
            }

            IMessageHandler h = null;
            if (defaultHandlers.TryGetValue(messageId, out h))
                ExecuteHandler(robot, h, ref package);
        }

        static void ExecuteHandler(Robot robot, IMessageHandler handler, ref Package package)
        {
            try
            {
                //StatisticsData.StatisticsRecv(robot.RobotID, (MessageID)package.header.msg);
                handler.Execute(robot, package.message);               
            }
            catch (Exception e)
            {
                GameLog.LogError("Exception when process response " + package.header);
                GameLog.LogException(e);
            }
        }
    }
}