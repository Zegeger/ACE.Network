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
    /// These are animations. Whenever a human, monster or object moves - one of these little messages is sent. Even idle emotes (like head scratching and nodding) are sent in this manner.
    /// </summary>
    public class SetObjectMovementS2C : Message
    {
        /// <summary>
        /// ID of the character moving
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The instance sequence value for this object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        
        /// <summary>
        /// Set of movement data
        /// </summary>
        [MessageProperty]
        public MovementData MovementData { get; } = new MovementData();
        


        public SetObjectMovementS2C() : base((MessageType)0xF74C, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public SetObjectMovementS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            ObjectInstanceSequence = reader.ReadUInt16();
            MovementData.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(ObjectInstanceSequence);
            MovementData.Pack(writer);

        }


    }
}
