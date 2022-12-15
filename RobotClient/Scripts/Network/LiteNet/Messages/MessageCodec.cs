using System;
using System.IO;
using System.Reflection;

namespace LiteNet
{
    public class MessageCodec
    {
        public delegate void _Serialize<T>(Stream stream, T message);
        public delegate byte[] _SerializeToBytes<T>(T message);
        public delegate T _DeserializeLength<T>(Stream stream, int length);
        public delegate T _Deserialize<T>(byte[] bytes);

        Delegate serialize;
        Delegate serializeToBytes;
        Delegate deserializeLength;
        Delegate deserialize;

        internal MessageCodec(Type messageType)
        {
            serialize = CreateDelegate(typeof(_Serialize<>), messageType, "Serialize", typeof(Stream), messageType);
            serializeToBytes = CreateDelegate(typeof(_SerializeToBytes<>), messageType, "SerializeToBytes", messageType);
            deserializeLength = CreateDelegate(typeof(_DeserializeLength<>), messageType, "DeserializeLength", typeof(Stream), typeof(int));
            deserialize = CreateDelegate(typeof(_Deserialize<>), messageType, "Deserialize", typeof(byte[]));
        }

        public void Serialize(Stream stream, object message)
        {
            serialize.DynamicInvoke(stream, message);
        }

        public byte[] SerializeToBytes(object message)
        {
            return (byte[])serializeToBytes.DynamicInvoke(message);
        }

        public T DeserializeLength<T>(Stream stream, int length)
        {
            return (T)deserializeLength.DynamicInvoke(stream, length);
        }

        public T Deserialize<T>(byte[] bytes)
        {
            return (T)deserialize.DynamicInvoke(bytes);
        }

        Delegate CreateDelegate(Type delegateType, Type messageType, string name, params Type[] parameterTypes)
        {
            var method = messageType.GetMethod(
                name,
                BindingFlags.Public | BindingFlags.Static,
                null, parameterTypes, null);
            if (null == method)
                throw new SerializeMethodNotFoundException(name, messageType);

            delegateType = delegateType.MakeGenericType(messageType);
            return Delegate.CreateDelegate(delegateType, method);
        }
    }
}