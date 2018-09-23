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
    /// Turn to event data
    /// </summary>
    public class TurnToEventC2S : OrderedMessage
    {
        /// <summary>
        /// set of turning data
        /// </summary>
        [MessageProperty]
        public TurnToEventPack Ttep { get; } = new TurnToEventPack();
        


        public TurnToEventC2S() : base((MessageType)0xF649, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public TurnToEventC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Ttep.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Ttep.Pack(writer);

        }


    }
}
