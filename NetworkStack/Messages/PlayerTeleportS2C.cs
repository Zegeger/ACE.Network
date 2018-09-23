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
    /// Instructs the client to show the portal graphic.
    /// </summary>
    public class PlayerTeleportS2C : Message
    {
        /// <summary>
        /// The teleport sequence value for the object
        /// </summary>
        [MessageProperty]
        public ushort ObjectTeleportSequence { get; set; }        
        


        public PlayerTeleportS2C() : base((MessageType)0xF751, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public PlayerTeleportS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectTeleportSequence = reader.ReadUInt16();
            reader.Align();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectTeleportSequence);
            writer.Align();

        }


    }
}
