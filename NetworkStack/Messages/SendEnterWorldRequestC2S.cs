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
    /// The user has clicked 'Enter'. This message does not contain the ID of the character logging on; that comes later.
    /// </summary>
    public class SendEnterWorldRequestC2S : Message
    {


        public SendEnterWorldRequestC2S() : base((MessageType)0xF7C8, MessageDirection.ClientToServer, (Queues)0x00000004)
        { }

        public SendEnterWorldRequestC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {

        }


    }
}
