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
    /// Display a message in a popup message window.
    /// </summary>
    public class PopUpStringS2C : OrderedMessage
    {
        /// <summary>
        /// the message text
        /// </summary>
        [MessageProperty]
        public string Message { get; set; }        
        


        public PopUpStringS2C() : base((MessageType)0x0004, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PopUpStringS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Message = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Message);

        }


    }
}
