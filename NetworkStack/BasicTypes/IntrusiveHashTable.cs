using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    public class IntrusiveHashTable<T, U> : BaseTable<T, U>
    {
        public IntrusiveHashTable(ReadFunction ReadFunc, WriteFunction WriteFunc) : base(ReadFunc, WriteFunc)
        {
        }

        public override void Unpack(BinaryReader reader)
        {
            byte buckets = reader.ReadByte();
            uint count = reader.ReadUIntCompressed8();
            for(uint i = 0; i < count; i++)
            {
                var pair = readFunc(reader);
                this.Add(pair.Key, pair.Value);
            }
        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((byte)0);
            writer.WriteUIntCompressed8((uint)this.Count);
            foreach(var pair in this)
            {
                writeFunc(writer, pair);
            }
        }
    }
}
