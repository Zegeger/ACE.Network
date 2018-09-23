using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACE.Network.Types
{
    public class PackableHashTable<T, U> : BaseTable<T, U>
    {
        public PackableHashTable(ReadFunction ReadFunc, WriteFunction WriteFunc) : base(ReadFunc, WriteFunc)
        {
        }

        public override void Unpack(BinaryReader reader)
        {
            ushort count = reader.ReadUInt16();
            ushort buckets = reader.ReadUInt16();
            for (uint i = 0; i < count; i++)
            {
                var pair = readFunc(reader);
                this.Add(pair.Key, pair.Value);
            }
        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((ushort)this.Count);
            writer.Write((ushort)0);
            foreach (var pair in this)
            {
                writeFunc(writer, pair);
            }
        }
    }
}
