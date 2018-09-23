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
    /// Contains the text associated with an emote action.
    /// </summary>
    public class HearSoulEmoteS2C : Message
    {
        /// <summary>
        /// The ID of the character performing the emote - used for squelch/radar filtering.
        /// </summary>
        [MessageProperty]
        public uint Sender { get; set; }        
        
        /// <summary>
        /// Name of the character performing the emote.
        /// </summary>
        [MessageProperty]
        public string SenderName { get; set; }        
        
        /// <summary>
        /// Text representation of the emote.
        /// </summary>
        [MessageProperty]
        public string Text { get; set; }        
        


        public HearSoulEmoteS2C() : base((MessageType)0x01E2, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HearSoulEmoteS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sender = reader.ReadUInt32();
            SenderName = reader.ReadString16L();
            Text = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sender);
            writer.WriteString16L(SenderName);
            writer.WriteString16L(Text);

        }


    }
}
