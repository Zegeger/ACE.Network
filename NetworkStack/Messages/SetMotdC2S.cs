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
    /// Sets the allegiance message of the day, /allegiance motd set
    /// </summary>
    public class SetMotdC2S : OrderedMessage
    {
        /// <summary>
        /// Text motd to display
        /// </summary>
        [MessageProperty]
        public string Msg { get; set; }        
        


        public SetMotdC2S() : base((MessageType)0x0254, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetMotdC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Msg = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Msg);

        }


    }
}
