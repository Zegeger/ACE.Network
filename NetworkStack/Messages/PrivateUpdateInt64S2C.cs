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
    /// Set or update a Character Int64 property value
    /// </summary>
    public class PrivateUpdateInt64S2C : Message
    {
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// Int64 property ID
        /// </summary>
        [MessageProperty]
        public Int64PropertyID Key { get; set; }        
        
        /// <summary>
        /// Int64 property value
        /// </summary>
        [MessageProperty]
        public long Value { get; set; }        
        


        public PrivateUpdateInt64S2C() : base((MessageType)0x02CF, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PrivateUpdateInt64S2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Key = (Int64PropertyID)reader.ReadUInt32();
            Value = reader.ReadInt64();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write((uint)Key);
            writer.Write(Value);

        }


    }
}
