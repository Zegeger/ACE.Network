using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// A ulong property value
    /// </summary>
    public class Bitfield64PropertyValue : PropertyValue
    {
        public ulong Value { get; set; }

        override public void Pack(BinaryWriter writer)
        {
            writer.Write(Value);
        }

        override public void Unpack(BinaryReader reader)
        {
            Value = reader.ReadUInt64();
        }
    }
}
