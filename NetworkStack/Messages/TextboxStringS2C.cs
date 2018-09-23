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
    /// Display a message in the chat window.
    /// </summary>
    public class TextboxStringS2C : Message
    {
        /// <summary>
        /// the message text
        /// </summary>
        [MessageProperty]
        public string Text { get; set; }        
        
        /// <summary>
        /// the message type, controls color and @filter processing
        /// </summary>
        [MessageProperty]
        public ChatMessageType Type { get; set; }        
        


        public TextboxStringS2C() : base((MessageType)0xF7E0, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public TextboxStringS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Text = reader.ReadString16L();
            Type = (ChatMessageType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Text);
            writer.Write((uint)Type);

        }


    }
}
