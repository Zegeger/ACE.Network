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
    /// Direct message by name
    /// </summary>
    public class TalkDirectByNameC2S : OrderedMessage
    {
        /// <summary>
        /// The message text
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        
        /// <summary>
        /// Name of person you are sending a message to
        /// </summary>
        [MessageProperty]
        public string TargetName { get; set; }        
        


        public TalkDirectByNameC2S() : base((MessageType)0x005D, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public TalkDirectByNameC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Msg = reader.ReadString16L();
            TargetName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Msg);
            writer.WriteString16L(TargetName);

        }


    }
}
