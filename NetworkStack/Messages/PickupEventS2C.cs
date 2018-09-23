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
    /// Sent when picking up an object
    /// </summary>
    public class PickupEventS2C : Message
    {
        /// <summary>
        /// The object being picked up
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The instance sequence value for the object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        
        /// <summary>
        /// The position sequence value for the object
        /// </summary>
        [MessageProperty]
        public ushort ObjectPositionSequence { get; set; }        
        


        public PickupEventS2C() : base((MessageType)0xF74A, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public PickupEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            ObjectInstanceSequence = reader.ReadUInt16();
            ObjectPositionSequence = reader.ReadUInt16();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(ObjectInstanceSequence);
            writer.Write(ObjectPositionSequence);

        }


    }
}
