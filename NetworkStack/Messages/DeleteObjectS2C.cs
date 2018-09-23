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
    /// Sent whenever an object is being deleted from the scene.
    /// </summary>
    public class DeleteObjectS2C : Message
    {
        /// <summary>
        /// The object that was recently erased.
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The instance sequence value for the object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        


        public DeleteObjectS2C() : base((MessageType)0xF747, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public DeleteObjectS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            ObjectInstanceSequence = reader.ReadUInt16();
            reader.Align();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(ObjectInstanceSequence);
            writer.Align();

        }


    }
}
