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
    /// Clears the player's corpse looting consent list, /consent clear
    /// </summary>
    public class ClearPlayerConsentListC2S : OrderedMessage
    {


        public ClearPlayerConsentListC2S() : base((MessageType)0x0216, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ClearPlayerConsentListC2S(BinaryReader reader) : this()
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
