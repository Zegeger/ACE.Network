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
    /// A message to be displayed in the chat window, spoken by a nearby player, NPC or creature
    /// </summary>
    public class HearSpeechS2C : Message
    {
        /// <summary>
        /// message text
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        
        /// <summary>
        /// sender name
        /// </summary>
        [MessageProperty]
        public string SenderName { get; set; }        
        
        /// <summary>
        /// sender ID
        /// </summary>
        [MessageProperty]
        public uint SenderID { get; set; }        
        
        /// <summary>
        /// message type
        /// </summary>
        [MessageProperty]
        public ChatMessageType Type { get; set; }        
        


        public HearSpeechS2C() : base((MessageType)0x02BB, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HearSpeechS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Msg = reader.ReadString16L();
            SenderName = reader.ReadString16L();
            SenderID = reader.ReadUInt32();
            Type = (ChatMessageType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Msg);
            writer.WriteString16L(SenderName);
            writer.Write(SenderID);
            writer.Write((uint)Type);

        }


    }
}
