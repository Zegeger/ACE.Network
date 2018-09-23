using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;
using ACE.Network.PropertyTypes;

namespace ACE.Network.Types
{
    public class PropertyCollection
    {
        /// <summary>
        /// A table of properties.
        /// </summary>
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

        public void Unpack(BinaryReader reader)
        {
            Properties.Unpack(reader);
        }

        public void Pack(BinaryWriter writer)
        {
            Properties.Pack(writer);
        }

        public T GetProperty<T>(PropertyType type) where T : PropertyValue
        {
            if (Properties.ContainsKey(type))
            {
                return (T)Properties[type].Value;
            }
            return null;
        }

        public T AddProperty<T>(PropertyType type) where T : PropertyValue, new()
        {
            BaseProperty bp = new BaseProperty();
            bp.Type = type;
            bp.Value = new T();
            Properties.Add(type, bp);
            return (T)bp.Value;
        }
    }
}
