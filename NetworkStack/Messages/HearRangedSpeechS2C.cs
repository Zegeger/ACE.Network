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
    public class HearRangedSpeechS2C : Message
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
        /// sender ID, must be between 0x50000001 and 0x6FFFFFFF to appear as clickable
        /// </summary>
        [MessageProperty]
        public uint SenderID { get; set; }        
        
        /// <summary>
        /// broadcast range
        /// </summary>
        [MessageProperty]
        public float Range { get; set; }        
        
        /// <summary>
        /// message type
        /// </summary>
        [MessageProperty]
        public ChatMessageType Type { get; set; }        
        


        public HearRangedSpeechS2C() : base((MessageType)0x02BC, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HearRangedSpeechS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Msg = reader.ReadString16L();
            SenderName = reader.ReadString16L();
            SenderID = reader.ReadUInt32();
            Range = reader.ReadSingle();
            Type = (ChatMessageType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Msg);
            writer.WriteString16L(SenderName);
            writer.Write(SenderID);
            writer.Write(Range);
            writer.Write((uint)Type);

        }


    }
}
