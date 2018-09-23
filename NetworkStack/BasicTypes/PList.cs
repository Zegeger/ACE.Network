using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACE.Network.Types
{
    public class PList<T> : BaseList<T>
    {
        public PList(ReadFunction ReadFunc, WriteFunction WriteFunc) : base(ReadFunc, WriteFunc)
        {
        }

        public override void Unpack(BinaryReader reader)
        {
            int count = reader.ReadInt32();
            for (uint i = 0; i < count; i++)
            {
                var item = readFunc(reader);
                this.Add(item);
            }
        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((int)this.Count);
            foreach (var item in this)
            {
                writeFunc(writer, item);
            }
        }
    }
}
