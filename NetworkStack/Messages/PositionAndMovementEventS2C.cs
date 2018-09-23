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
    /// Sets both the position and movement, such as when materializing at a lifestone
    /// </summary>
    public class PositionAndMovementEventS2C : Message
    {
        /// <summary>
        /// ObjectID of the character doing the animation
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        [MessageProperty]
        public PositionPack Position { get; } = new PositionPack();
        
        /// <summary>
        /// Set of movement data
        /// </summary>
        [MessageProperty]
        public MovementData MovementData { get; } = new MovementData();
        


        public PositionAndMovementEventS2C() : base((MessageType)0xF619, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public PositionAndMovementEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            Position.Unpack(reader);
            MovementData.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            Position.Pack(writer);
            MovementData.Pack(writer);

        }


    }
}
