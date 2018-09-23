using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// A boolean property value
    /// </summary>
    public class BooleanPropertyValue : PropertyValue
    {
        public bool Value { get; set; }

        override public void Pack(BinaryWriter writer)
        {
            writer.Write(Value);
        }

        override public void Unpack(BinaryReader reader)
        {
            Value = reader.ReadBoolean();
        }
    }
}
