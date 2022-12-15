using System;
using System.Reflection;
using System.Collections.Generic;

namespace LiteNet
{
    internal static class MessageMapping
    {
        static Type[] idToType;
        static MessageCodec[] idToCodec;
        static Dictionary<Type, MessageID> typeToId;

        public static void Init()
        {
            idToType = new Type[(int)MessageID.Max];
            idToCodec = new MessageCodec[(int)MessageID.Max];
            typeToId = new Dictionary<Type, MessageID>();

            var assembly = Assembly.GetExecutingAssembly();
            foreach (short value in Enum.GetValues(typeof(MessageID)))
            {
                MessageID id = (MessageID)value;
                if (id != MessageID.None && id != MessageID.Max)
                {
                    string messageName = id.ToString();
                    Type messageType = assembly.GetType("ProtobufPacket." + messageName);
                    if (null == messageType)
                        throw new MessageTypeNotFoundException(messageName);

                    idToType[value] = messageType;
                    idToCodec[value] = MessageCodecCollection.Get(messageType);
                    typeToId[messageType] = id;
                }
            }
        }

        public static bool CheckMessageID(int messageId)
        {
            if (messageId > 0 && messageId < idToType.Length)
                return null != idToType[messageId];
            return false;
        }

        public static Type GetMessageType(int messageId)
        {
            if (messageId > 0 && messageId < idToType.Length)
                return idToType[messageId];
            return null;
        }

        public static MessageID GetMessageID<T>() where T : IMessage
        {
            return GetMessageID(typeof(T));
        }

        public static MessageID GetMessageID(Type messageType)
        {
            if (typeToId.TryGetValue(messageType, out MessageID id))
                return id;
            else
                return MessageID.None;
        }

        public static MessageCodec GetCodec(int messageId)
        {
            if (messageId > 0 && messageId < idToType.Length)
                return idToCodec[messageId];
            return null;
        }
    }
}
