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
    /// Teleport to the marketplace
    /// </summary>
    public class TeleToMarketplaceC2S : OrderedMessage
    {


        public TeleToMarketplaceC2S() : base((MessageType)0x028D, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public TeleToMarketplaceC2S(BinaryReader reader) : this()
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
