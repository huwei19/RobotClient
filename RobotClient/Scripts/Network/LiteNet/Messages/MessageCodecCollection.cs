using System;
using System.Collections.Generic;

namespace LiteNet
{
    public static partial class MessageCodecCollection
    {
        static Dictionary<Type, MessageCodec> collection;

        public static MessageCodec Get(Type messageType)
        {
            MessageCodec value;
            collection.TryGetValue(messageType, out value);
            
            //collection.TryGetValue(messageType, out MessageCodec value);
            return value;
        }

        public static MessageCodec Get<T>()
        {
            return Get(typeof(T));
        }
    }
}
