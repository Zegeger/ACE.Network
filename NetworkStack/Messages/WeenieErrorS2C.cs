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
    /// Display a status message in the chat window.
    /// </summary>
    public class WeenieErrorS2C : OrderedMessage
    {
        /// <summary>
        /// the type of status message to display
        /// </summary>
        [MessageProperty]
        public StatusMessage Type { get; set; }        
        


        public WeenieErrorS2C() : base((MessageType)0x028A, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public WeenieErrorS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Type = (StatusMessage)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Type);

        }


    }
}
