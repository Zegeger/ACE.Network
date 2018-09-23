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
    /// Set or update a Character Position property value
    /// </summary>
    public class PrivateUpdatePositionS2C : Message
    {
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// Position property ID
        /// </summary>
        [MessageProperty]
        public PositionPropertyID Key { get; set; }        
        
        /// <summary>
        /// Position property value
        /// </summary>
        [MessageProperty]
        public Position Value { get; } = new Position();
        


        public PrivateUpdatePositionS2C() : base((MessageType)0x02DB, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PrivateUpdatePositionS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Key = (PositionPropertyID)reader.ReadUInt32();
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
