using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ACE.Network.Types;
using ACE.Network.Enums;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// A hash table property value
    /// </summary>
    public class StructPropertyValue : PropertyValue
    {
        public IntrusiveHashTable<PropertyType, BaseProperty> Properties { get; } = new IntrusiveHashTable<PropertyType, BaseProperty>(ReadProperty, WriteProperty);

        static KeyValuePair<PropertyType, BaseProperty> ReadProperty(BinaryReader reader)
        {
            var key = (PropertyType)reader.ReadUInt32();
            BaseProperty property = new BaseProperty();
            property.Unpack(reader);
            return new KeyValuePair<PropertyType, BaseProperty>(key, property);
        }

        static void WriteProperty(BinaryWriter writer, KeyValuePair<PropertyType, BaseProperty> pair)
        {
            writer.Write((uint)pair.Key);
            pair.Value.Pack(writer);
        }

        override public void Pack(BinaryWriter writer)
        {
            Properties.Pack(writer);
        }

        override public void Unpack(BinaryReader reader)
        {
            Properties.Clear();
            Properties.Unpack(reader);
        }

        public T GetProperty<T>(PropertyType type) where T:PropertyValue
        {
            if(Properties.ContainsKey(type))
            {
                return (T)Properties[type].Value;
            }
            return null;
        }

        public T AddProperty<T>(PropertyType type) where T : PropertyValue, new()
        {
            BaseProperty bp = new BaseProperty
            {
                Type = type,
                Value = new T()
            };
            Properties.Add(type, bp);
            return (T)bp.Value;
        }
    }
}
