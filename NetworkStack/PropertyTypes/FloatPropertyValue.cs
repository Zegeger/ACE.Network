using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// A float property value
    /// </summary>
    public class FloatPropertyValue : PropertyValue
    {
        public float Value { get; set; }

        override public void Pack(BinaryWriter writer)
        {
            writer.Write(Value);
        }

        override public void Unpack(BinaryReader reader)
        {
            Value = reader.ReadSingle();
        }
    }
}
