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
    /// Set or update an Object DID property value
    /// </summary>
    public class PrivateUpdateDataIDS2C : Message
    {
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// Data property ID
        /// </summary>
        [MessageProperty]
        public DataPropertyID Key { get; set; }        
        
        /// <summary>
        /// Resource property value
        /// </summary>
        [MessageProperty]
        public uint Value { get; set; }        
        


        public PrivateUpdateDataIDS2C() : base((MessageType)0x02D7, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PrivateUpdateDataIDS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Key = (DataPropertyID)reader.ReadUInt32();
            Value = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write((uint)Key);
            writer.Write(Value);

        }


    }
}
