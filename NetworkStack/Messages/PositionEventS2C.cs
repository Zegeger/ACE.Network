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
    /// Sets the position/motion of an object
    /// </summary>
    public class PositionEventS2C : Message
    {
        /// <summary>
        /// The object with the position changing.
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The current or starting location.
        /// </summary>
        [MessageProperty]
        public PositionPack Position { get; } = new PositionPack();
        


        public PositionEventS2C() : base((MessageType)0xF748, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public PositionEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            Position.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            Position.Pack(writer);

        }


    }
}
