using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACE.Network.Types
{
    public class PHashTable<T, U> : BaseTable<T, U>
    {
        public PHashTable(ReadFunction ReadFunc, WriteFunction WriteFunc) : base(ReadFunc, WriteFunc)
        {
        }

        public override void Unpack(BinaryReader reader)
        {
            uint count = reader.ReadUInt32() & 0xFFFFFF;
            for (uint i = 0; i < count; i++)
            {
                var pair = readFunc(reader);
                this.Add(pair.Key, pair.Value);
            }
        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)(this.Count & 0xFFFFFF));
            foreach (var pair in this)
            {
                writeFunc(writer, pair);
            }
        }
    }
}
