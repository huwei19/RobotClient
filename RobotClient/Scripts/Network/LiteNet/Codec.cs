using System;
using System.IO;

namespace LiteNet
{
    internal class Codec
    {
        public static void Encode(ref Package package, byte[] key, MemoryStream outputStream)
        {
            try
            {
                long pos = outputStream.Position;
                outputStream.Seek(Header.Size, SeekOrigin.Current);
                var msgCodec = MessageMapping.GetCodec(package.header.msg);
                if (null == msgCodec)
                    throw new MessageNotSupportException(package.header.msg);
                msgCodec.Serialize(outputStream, package.message);

                package.header.len = (int)(outputStream.Position - pos);
                byte[] buffer = outputStream.GetBuffer();
                int start = (int)pos + Header.Size;
                int size = package.header.len - Header.Size;
                if (IsCryptoMessage(package.header.msg))
                    XorCrypto.XorEncrypt(buffer, start, size, key);
                package.header.crc = CRC32.GetCRC32(buffer, start, size);

                outputStream.Seek(-package.header.len, SeekOrigin.Current);
                Header.Encode(package.header, outputStream);
                outputStream.Seek(package.header.len - Header.Size, SeekOrigin.Current);

                //NetLog.VerboseFormat( "Encode: {0}, {1}",
                //    package.header, 
                //    null != package.message ? package.message.Dump() : "opaque bytes");
            }
            catch (Exception e)
            {
                throw new CodecException(
                    string.Format("[{0}] Encode Error", (MessageID)package.header.msg),
                    e);
            }
        }

        public static Package Decode(byte[] key, MemoryStream inputStream)
        {
            short messageId = -1;
            try
            {
                Header header;
                Header.Decode(inputStream, out header);
                messageId = header.msg;

                Package package = default;
                package.header = header;

                var msgCodec = MessageMapping.GetCodec(package.header.msg);
                if (null == msgCodec)
                    throw new MessageNotSupportException(package.header.msg);

                int len = package.header.len - Header.Size;
                if (IsCryptoMessage(package.header.msg))
                {
                    byte[] buffer = inputStream.GetBuffer();
                    int start = (int)inputStream.Position;
                    XorCrypto.XorDecrypt(buffer, start, len, key);
                }

                package.message = msgCodec.DeserializeLength<IMessage>(inputStream, len);
                //NetLog.VerboseFormat("Decode: {0}, {1}", header, package.message.Dump());
                return package;
            }
            catch (CodecException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new CodecException(
                    string.Format("[{0}] Decode Error", MessageIDToString(messageId)),
                    e);
            }
        }

        static internal bool IsCryptoMessage(short messageId)
        {
            MessageID msg = (MessageID)messageId;
            switch (msg)
            {
                case MessageID.GC_SESSION:
                case MessageID.XX_REQUEST_HEARTBEAT:
                case MessageID.XX_RESPONSE_HEARTBEAT:
                    return false;
            }
            return true;
        }

        static string MessageIDToString(short messageId)
        {
            if (messageId > 0 && messageId < (int)MessageID.Max)
                return ((MessageID)messageId).ToString();
            else
                return messageId.ToString();
        }
    }
}