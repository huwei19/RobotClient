/*
+-------------------+------------------+------------------+
| discardable bytes |  readable bytes  |  writable bytes  |
|                   |     (CONTENT)    |                  |
+-------------------+------------------+------------------+
|                   |                  |                  |
0      <=      readerIndex   <=   writerIndex    <=    capacity
*/

using System;

namespace LiteNet
{
    internal sealed class ChannelBufferLite
    {
        const int InitialSize = 1048576; 

        byte[] buffer = new byte[InitialSize];
        int readIndex = 0;
        int writeIndex = 0;
        int capacity = InitialSize;

        public void Clear()
        {
            readIndex = writeIndex = 0;
        }

        public void Write(byte[] data, int size)
        {
            EnsureCapcity(size);
            Buffer.BlockCopy(data, 0, buffer, writeIndex, size);
            writeIndex += size;
        }

        public byte[] GetBuffer(out int offset, out int size)
        {
            offset = readIndex;
            size = ReadableSize;
            return buffer;
        }

        public void Consume(int size)
        {
            if (size > ReadableSize)
                throw new ChannelBufferLiteExpcetion("consume size error");

            readIndex += size;
        }

        void EnsureCapcity(int size)
        {
            if (WritableSize >= size)
                return;

            int readable_size = ReadableSize;
            if (DiscardableSize + WritableSize >= size)
            {
                Buffer.BlockCopy(buffer, readIndex, buffer, 0, readable_size);
                readIndex = 0;
                writeIndex = readable_size;
            }
            else
            {
                int size_requirement = readable_size + size;
                int new_capacity = capacity;
                while (new_capacity < size_requirement)
                    new_capacity = (int)(new_capacity * 1.5);

                byte[] new_buffer = new byte[new_capacity];
                Buffer.BlockCopy(buffer, readIndex, new_buffer, 0, readable_size);

                buffer = new_buffer;
                readIndex = 0;
                writeIndex = readable_size;
                capacity = new_capacity;
            }
        }

        int ReadableSize { get { return writeIndex - readIndex; } }
        int WritableSize { get { return capacity - writeIndex; } }
        int DiscardableSize { get { return readIndex; } }
    }
}
