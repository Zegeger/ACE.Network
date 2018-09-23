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
    /// Allegiance update cancelled
    /// </summary>
    public class AllegianceUpdateAbortedS2C : OrderedMessage
    {
        /// <summary>
        /// Failure type
        /// </summary>
        [MessageProperty]
        public StatusMessage FailureType { get; set; }        
        


        public AllegianceUpdateAbortedS2C() : base((MessageType)0x0003, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AllegianceUpdateAbortedS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            FailureType = (StatusMessage)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)FailureType);

        }


    }
}
