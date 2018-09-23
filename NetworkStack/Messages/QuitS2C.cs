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
    /// Member left fellowship
    /// </summary>
    public class QuitS2C : OrderedMessage
    {
        /// <summary>
        /// Whether to disband the fellowship while quiting
        /// </summary>
        [MessageProperty]
        public bool Disband { get; set; }        
        


        public QuitS2C() : base((MessageType)0x00A3, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public QuitS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Disband = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(Disband);

        }


    }
}
