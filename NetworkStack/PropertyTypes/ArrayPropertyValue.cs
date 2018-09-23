using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// An array of other properties
    /// </summary>
    public class ArrayPropertyValue : PropertyValue
    {
        public List<BaseProperty> Value { get; } = new List<BaseProperty>();

        override public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Value.Count);
            foreach(var prop in Value)
            {
                prop.Pack(writer);
            }
        }

        override public void Unpack(BinaryReader reader)
        {
            Value.Clear();
            uint count = reader.ReadUInt32();
            for(int i = 0; i < count; i++)
            {
                BaseProperty prop = new BaseProperty();
                prop.Unpack(reader);
                Value.Add(prop);
            }
        }
    }
}
