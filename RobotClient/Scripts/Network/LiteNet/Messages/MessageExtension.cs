using System;
using System.IO;

namespace LiteNet
{
    public static class MessageExtension
    {
        public static void Serialize(this object message, Stream stream)
        {
#if UNITY_EDITOR
            MessageCodecCollection.Init();
#endif // UNITY_EDITOR
            var codec = MessageCodecCollection.Get(message.GetType());
            codec.Serialize(stream, message);
        }

        public static byte[] SerializeToBytes(this object message)
        {
#if UNITY_EDITOR
            MessageCodecCollection.Init();
#endif // UNITY_EDITOR
            var codec = MessageCodecCollection.Get(message.GetType());
            return codec.SerializeToBytes(message);
        }

        public static T DeserializeLength<T>(Stream stream, int length)
        {
#if UNITY_EDITOR
            MessageCodecCollection.Init();
#endif // UNITY_EDITOR
            var codec = MessageCodecCollection.Get(typeof(T));
            return codec.DeserializeLength<T>(stream, length);
        }

        public static T Deserialize<T>(byte[] bytes)
        {
#if UNITY_EDITOR
            MessageCodecCollection.Init();
#endif // UNITY_EDITOR
            var codec = MessageCodecCollection.Get(typeof(T));
            return codec.Deserialize<T>(bytes);
        }
    }
}