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
    /// ChannelBroadcast: Group Chat
    /// </summary>
    public class ChannelBroadcastC2S : OrderedMessage
    {
        /// <summary>
        /// Channel id, TODO get enum
        /// </summary>
        [MessageProperty]
        public uint Chan { get; set; }        
        
        /// <summary>
        /// Message being sent
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        


        public ChannelBroadcastC2S() : base((MessageType)0x0147, MessageDirection.ClientToServer, (Queues)0x00000009)
        { }

        public ChannelBroadcastC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Chan = reader.ReadUInt32();
            Msg = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Chan);
            writer.WriteString16L(Msg);

        }


    }
}
