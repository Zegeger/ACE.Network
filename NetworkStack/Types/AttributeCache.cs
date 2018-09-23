////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// The AttributeCache structure contains information about a character attributes.
    /// </summary>
    public class AttributeCache : IPackable
    {
        /// <summary>
        /// The attributes included in the character description - this is always 0x1FF
        /// </summary>
        [MessageProperty]
        public uint AttributeFlags { get; set; } = 0x01FF;        
        
        /// <summary>
        /// strength attribute information
        /// </summary>
        [MessageProperty]
        public AttributeData Strength { get; } = new AttributeData();
        
        /// <summary>
        /// endurance attribute information
        /// </summary>
        [MessageProperty]
        public AttributeData Endurance { get; } = new AttributeData();
        
        /// <summary>
        /// quickness attribute information
        /// </summary>
        [MessageProperty]
        public AttributeData Quickness { get; } = new AttributeData();
        
        /// <summary>
        /// coordination attribute information
        /// </summary>
        [MessageProperty]
        public AttributeData Coordination { get; } = new AttributeData();
        
        /// <summary>
        /// focus attribute information
        /// </summary>
        [MessageProperty]
        public AttributeData Focus { get; } = new AttributeData();
        
        /// <summary>
        /// self attribute information
        /// </summary>
        [MessageProperty]
        public AttributeData Self { get; } = new AttributeData();
        
        /// <summary>
        /// health vital information
        /// </summary>
        [MessageProperty]
        public SecondaryAttribute Health { get; } = new SecondaryAttribute();
        
        /// <summary>
        /// stamina vital information
        /// </summary>
        [MessageProperty]
        public SecondaryAttribute Stamina { get; } = new SecondaryAttribute();
        
        /// <summary>
        /// mana vital information
        /// </summary>
        [MessageProperty]
        public SecondaryAttribute Mana { get; } = new SecondaryAttribute();
        


        public void Unpack(BinaryReader reader)
        {
            AttributeFlags = reader.ReadUInt32();
            if((AttributeFlags & 0x00000001) != 0)
            {
                Strength.Unpack(reader);
            }
            if((AttributeFlags & 0x00000002) != 0)
            {
                Endurance.Unpack(reader);
            }
            if((AttributeFlags & 0x00000004) != 0)
            {
                Quickness.Unpack(reader);
            }
            if((AttributeFlags & 0x00000008) != 0)
            {
                Coordination.Unpack(reader);
            }
            if((AttributeFlags & 0x00000010) != 0)
            {
                Focus.Unpack(reader);
            }
            if((AttributeFlags & 0x00000020) != 0)
            {
                Self.Unpack(reader);
            }
            if((AttributeFlags & 0x00000040) != 0)
            {
                Health.Unpack(reader);
            }
            if((AttributeFlags & 0x00000080) != 0)
            {
                Stamina.Unpack(reader);
            }
            if((AttributeFlags & 0x00000100) != 0)
            {
                Mana.Unpack(reader);
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(AttributeFlags);
            if((AttributeFlags & 0x00000001) != 0)
            {
                Strength.Pack(writer);
            }
            if((AttributeFlags & 0x00000002) != 0)
            {
                Endurance.Pack(writer);
            }
            if((AttributeFlags & 0x00000004) != 0)
            {
                Quickness.Pack(writer);
            }
            if((AttributeFlags & 0x00000008) != 0)
            {
                Coordination.Pack(writer);
            }
            if((AttributeFlags & 0x00000010) != 0)
            {
                Focus.Pack(writer);
            }
            if((AttributeFlags & 0x00000020) != 0)
            {
                Self.Pack(writer);
            }
            if((AttributeFlags & 0x00000040) != 0)
            {
                Health.Pack(writer);
            }
            if((AttributeFlags & 0x00000080) != 0)
            {
                Stamina.Pack(writer);
            }
            if((AttributeFlags & 0x00000100) != 0)
            {
                Mana.Pack(writer);
            }

        }


    }
}
