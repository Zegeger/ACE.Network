using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// An integer property value
    /// </summary>
    public class IntegerPropertyValue : PropertyValue
    {
        public int Value { get; set; }

        override public void Pack(BinaryWriter writer)
        {
            writer.Write(Value);
        }

        override public void Unpack(BinaryReader reader)
        {
            Value = reader.ReadInt32();
        }
    }
}
