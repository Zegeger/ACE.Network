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
    /// Offer or confirm stalemate
    /// </summary>
    public class StalemateC2S : OrderedMessage
    {
        /// <summary>
        /// Whether stalemate offer is active or not
        /// </summary>
        [MessageProperty]
        public bool On { get; set; }        
        


        public StalemateC2S() : base((MessageType)0x026E, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public StalemateC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            On = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(On);

        }


    }
}
