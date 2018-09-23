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
    /// Sends a message to a chat channel
    /// </summary>
    public class ChannelBroadcastS2C : OrderedMessage
    {
        /// <summary>
        /// Channel id, TODO get enum
        /// </summary>
        [MessageProperty]
        public uint Chan { get; set; }        
        
        /// <summary>
        /// the name of the player sending the message
        /// </summary>
        [MessageProperty]
        public string SenderName { get; set; }        
        
        /// <summary>
        /// Message being sent
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        


        public ChannelBroadcastS2C() : base((MessageType)0x0147, MessageDirection.ServerToClient, (Queues)0x00000003)
        { }

        public ChannelBroadcastS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Chan = reader.ReadUInt32();
            SenderName = reader.ReadString16L();
            Msg = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Chan);
            writer.WriteString16L(SenderName);
            writer.WriteString16L(Msg);

        }


    }
}
