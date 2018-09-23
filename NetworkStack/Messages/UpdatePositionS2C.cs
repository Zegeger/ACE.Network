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
    public class UpdatePositionS2C : Message
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
        /// Position property ID
        /// </summary>
        [MessageProperty]
        public PositionPropertyID Key { get; set; }        
        
        /// <summary>
        /// Position property value
        /// </summary>
        [MessageProperty]
        public Position Value { get; } = new Position();
        


        public UpdatePositionS2C() : base((MessageType)0x02DC, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdatePositionS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            ObjectID = reader.ReadUInt32();
            Key = (PositionPropertyID)reader.ReadUInt32();
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
