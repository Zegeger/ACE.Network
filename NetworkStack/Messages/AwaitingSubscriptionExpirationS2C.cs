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
    /// Sent when your subsciption is about to expire
    /// </summary>
    public class AwaitingSubscriptionExpirationS2C : Message
    {
        /// <summary>
        /// Time remaining before your subscription expires.
        /// </summary>
        [MessageProperty]
        public uint SecondsRemaining { get; set; }        
        


        public AwaitingSubscriptionExpirationS2C() : base((MessageType)0xF651, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AwaitingSubscriptionExpirationS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            SecondsRemaining = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(SecondsRemaining);

        }


    }
}
