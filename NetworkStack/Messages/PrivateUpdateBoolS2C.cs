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
    /// Set or update a Character Boolean property value
    /// </summary>
    public class PrivateUpdateBoolS2C : Message
    {
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// Boolean property ID
        /// </summary>
        [MessageProperty]
        public BooleanPropertyID Key { get; set; }        
        
        /// <summary>
        /// Boolean property value (0=False, 1=True)
        /// </summary>
        [MessageProperty]
        public bool Value { get; set; }        
        


        public PrivateUpdateBoolS2C() : base((MessageType)0x02D1, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PrivateUpdateBoolS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Key = (BooleanPropertyID)reader.ReadUInt32();
            Value = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write((uint)Key);
            writer.WriteBool32(Value);

        }


    }
}
