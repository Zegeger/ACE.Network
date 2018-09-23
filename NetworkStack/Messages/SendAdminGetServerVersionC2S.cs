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
    /// Sent if player is an PSR, I assume it displays the server version number
    /// </summary>
    public class SendAdminGetServerVersionC2S : Message
    {


        public SendAdminGetServerVersionC2S() : base((MessageType)0xF7CC, MessageDirection.ClientToServer, (Queues)0x00000002)
        { }

        public SendAdminGetServerVersionC2S(BinaryReader reader) : this()
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
