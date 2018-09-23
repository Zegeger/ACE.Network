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
    /// Direct message by ID
    /// </summary>
    public class TalkDirectC2S : OrderedMessage
    {
        /// <summary>
        /// The message text
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        
        [MessageProperty]
        public uint TargetID { get; set; }        
        


        public TalkDirectC2S() : base((MessageType)0x0032, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public TalkDirectC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Msg = reader.ReadString16L();
            TargetID = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Msg);
            writer.Write(TargetID);

        }


    }
}
