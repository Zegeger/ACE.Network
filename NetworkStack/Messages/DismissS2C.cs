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
    /// Member dismissed from fellowship
    /// </summary>
    public class DismissS2C : OrderedMessage
    {
        /// <summary>
        /// ID of player being dismissed from the fellowship
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        


        public DismissS2C() : base((MessageType)0x00A4, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public DismissS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Target);

        }


    }
}
