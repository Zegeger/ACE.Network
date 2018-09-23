using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ACE.Network.Enums;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// Represents a property of a specific type and value
    /// </summary>
    public class BaseProperty : IPackable
    {
        // Dictionary of all possible property types and the constuctor for their value types.
        // This is used to instantiate the value at runtime based on the indicated type
        static Dictionary<PropertyType, Func<PropertyValue>> propertyTypeTable = new Dictionary<PropertyType, Func<PropertyValue>>();
        static BaseProperty()
        {
            propertyTypeTable.Add(PropertyType.InactiveWindowOpacity, () => new FloatPropertyValue());
            propertyTypeTable.Add(PropertyType.ActiveWindowOpacity, () => new FloatPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowXPosition, () => new IntegerPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowYPosition, () => new IntegerPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowXSize, () => new IntegerPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowYSize, () => new IntegerPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowEnabled, () => new BooleanPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowArray, () => new ArrayPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowPropertyTable, () => new StructPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowTitle, () => new StringInfoPropertyValue());
            propertyTypeTable.Add(PropertyType.ChatWindowDisplayMask, () => new Bitfield64PropertyValue());
        }

        /// <summary>
        /// Data type for this property
        /// </summary>
        public PropertyType Type { get; set; }

        /// <summary>
        /// Value for this property
        /// </summary>
        public PropertyValue Value { get; set; }

        /// <summary>
        /// Writes the content of this property to the given BinaryWriter
        /// </summary>
        /// <param name="writer"></param>
        virtual public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Type);
            Value.Pack(writer);
        }

        /// <summary>
        /// Reads this property from the given BinaryReader
        /// </summary>
        /// <param name="reader"></param>
        virtual public void Unpack(BinaryReader reader)
        {
            Type = (PropertyType)reader.ReadUInt32();
            if (propertyTypeTable.ContainsKey(Type))
            {
                Value = propertyTypeTable[Type]();
                Value.Unpack(reader);
            }
            else
                throw new Exception("Unknown PropertyValue type");
        }
    }
}
