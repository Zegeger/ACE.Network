////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    /// <summary>
    /// Set or update a Character Attribute value
    /// </summary>
    public class PrivateUpdateAttributeS2C : Message
    {
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// attribute ID
        /// </summary>
        [MessageProperty]
        public AttributeID Key { get; set; }        
        
        /// <summary>
        /// attribute information
        /// </summary>
        [MessageProperty]
        public AttributeData Value { get; } = new AttributeData();
        


        public PrivateUpdateAttributeS2C() : base((MessageType)0x02E3, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PrivateUpdateAttributeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Key = (AttributeID)reader.ReadUInt32();
            Value.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write((uint)Key);
            Value.Pack(writer);

        }


    }
}
