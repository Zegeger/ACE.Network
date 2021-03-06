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
    /// Set or update a Character Vital value
    /// </summary>
    public class UpdateAttribute2ndS2C : Message
    {
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// object ID
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// vital ID
        /// </summary>
        [MessageProperty]
        public VitalID Key { get; set; }        
        
        /// <summary>
        /// vital information
        /// </summary>
        [MessageProperty]
        public SecondaryAttribute Value { get; } = new SecondaryAttribute();
        


        public UpdateAttribute2ndS2C() : base((MessageType)0x02E8, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateAttribute2ndS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            ObjectID = reader.ReadUInt32();
            Key = (VitalID)reader.ReadUInt32();
            Value.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write(ObjectID);
            writer.Write((uint)Key);
            Value.Pack(writer);

        }


    }
}
