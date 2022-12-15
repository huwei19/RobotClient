using System;

namespace LiteNet
{
    internal interface IMessageHandler
    {
        void Execute(Robot robot, IMessage message);
    }

    public abstract class MessageHandler<T> : IMessageHandler where T : IMessage
    {
        void IMessageHandler.Execute(Robot robot, IMessage message)
        {
            Execute(robot, (T)message);
        }

        protected abstract void Execute(Robot robot, T message);
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class MessageHandlerAttribute : Attribute
    {
        public MessageID messageId;

        public MessageHandlerAttribute(MessageID messageId)
        {
            this.messageId = messageId;
        }
    }
}
