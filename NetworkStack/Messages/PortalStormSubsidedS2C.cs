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
    /// The portal storm has subsided.
    /// </summary>
    public class PortalStormSubsidedS2C : OrderedMessage
    {


        public PortalStormSubsidedS2C() : base((MessageType)0x02CC, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PortalStormSubsidedS2C(BinaryReader reader) : this()
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
