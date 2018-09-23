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
    /// Set's the current state of the object. Client appears to only process the following state changes post creation: NoDraw, LightingOn, Hidden
    /// </summary>
    public class SetStateS2C : Message
    {
        /// <summary>
        /// The object being changed
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The new state for the object
        /// </summary>
        [MessageProperty]
        public PhysicsState NewState { get; set; }        
        
        /// <summary>
        /// The instance sequence value for this object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        
        /// <summary>
        /// The state sequence value for this object
        /// </summary>
        [MessageProperty]
        public ushort ObjectStateSequence { get; set; }        
        


        public SetStateS2C() : base((MessageType)0xF74B, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public SetStateS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            NewState = (PhysicsState)reader.ReadUInt32();
            ObjectInstanceSequence = reader.ReadUInt16();
            ObjectStateSequence = reader.ReadUInt16();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write((uint)NewState);
            writer.Write(ObjectInstanceSequence);
            writer.Write(ObjectStateSequence);

        }


    }
}
