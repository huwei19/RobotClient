using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

namespace LiteNet
{
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    internal struct Header
    {
        public int   len;
        public short msg;
        public short seq;
        public int   crc;

        public static int Size = Marshal.SizeOf<Header>();

        public override string ToString()
        {
            return string.Format(
                "{{len:{0} msg:{1} seq:{2} crc:{3:X}}}",
                len, (MessageID)msg, seq, crc);
        }

        public static void Encode(Header h, Stream o)
        {
            o.WriteTo(IPAddress.HostToNetworkOrder(h.len));
            o.WriteTo(IPAddress.HostToNetworkOrder(h.msg));
            o.WriteTo(IPAddress.HostToNetworkOrder(h.seq));
            o.WriteTo(IPAddress.HostToNetworkOrder(h.crc));
        }

        public static void Decode(Stream i, out Header h)
        {
            h = default(Header);
            h.len = IPAddress.NetworkToHostOrder(i.ReadInt32());
            h.msg = IPAddress.NetworkToHostOrder(i.ReadInt16());
            h.seq = IPAddress.NetworkToHostOrder(i.ReadInt16());
            h.crc = IPAddress.NetworkToHostOrder(i.ReadInt32());
        }

        public static bool Peek(byte[] buffer, int start, int size, out int len)
        {
            len = 0;
            if (size < sizeof(int))
                return false;

            len = BitConverter.ToInt32(buffer, start);
            len = IPAddress.NetworkToHostOrder(len);
            if (size < len)
                return false;

            return true;
        }
    }

    internal struct Package
    {
        public Header header;
        public IMessage message;
    }
}
