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
    /// Seems to be a legacy friends command, /friends old, for when Jan 2006 event changed the friends list
    /// </summary>
    public class SendFriendsCommandC2S : Message
    {
        /// <summary>
        /// Only 0 is used in client, I suspect it is list/display
        /// </summary>
        [MessageProperty]
        public uint Cmd { get; set; }        
        
        /// <summary>
        /// I assume it would be used to pass a friend to add/remove.  Display passes null string.
        /// </summary>
        [MessageProperty]
        public string Player { get; set; }        
        


        public SendFriendsCommandC2S() : base((MessageType)0xF7CD, MessageDirection.ClientToServer, (Queues)0x00000002)
        { }

        public SendFriendsCommandC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Cmd = reader.ReadUInt32();
            Player = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Cmd);
            writer.WriteString16L(Player);

        }


    }
}
