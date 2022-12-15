using System;

namespace LiteNet
{
    public class MessageTypeNotFoundException : Exception
    {
        public MessageTypeNotFoundException(string type)
            : base("[LiteNet]: Message type not found: " + type)
        { }
    }

    public class SerializeMethodNotFoundException : Exception
    {
        public SerializeMethodNotFoundException(string methodName, Type type)
            : base(string.Format("[LiteNet]: {0} method not found for message: {1}", methodName, type))
        { }
    }

    public sealed class MessageNotSupportException : Exception
    {
        public MessageNotSupportException(int messageId)
            : base("[LiteNet]: Message not supported, id: " + messageId)
        { }

        public MessageNotSupportException(Type messageType)
            : base("[LiteNet]: Message not supported, id: " + messageType)
        { }
    }

    public sealed class ChannelBufferLiteExpcetion : Exception
    {
        public ChannelBufferLiteExpcetion(string message) 
            : base("[LiteNet]: " + message)
        { }
    }

    public sealed class CodecException : Exception
    {
        public CodecException(string message, Exception inner) : base(message, inner) { }
    }

    public sealed class SessionException : Exception
    {
        public SessionException(string message) : base(message) { }
    }

    public sealed class MessageHandlerException : Exception
    {
        public MessageHandlerException(string message) : base(message) { }
    }

    public class ConnectionException : Exception
    {
        public ConnectionException(string message) : base(message) { }
    }
}
