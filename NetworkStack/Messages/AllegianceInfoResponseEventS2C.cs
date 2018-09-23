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
    /// Returns data for a player's allegiance information
    /// </summary>
    public class AllegianceInfoResponseEventS2C : OrderedMessage
    {
        /// <summary>
        /// Target of the request
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        
        /// <summary>
        /// Allegiance Profile Data
        /// </summary>
        [MessageProperty]
        public AllegianceProfile Prof { get; } = new AllegianceProfile();
        


        public AllegianceInfoResponseEventS2C() : base((MessageType)0x027C, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AllegianceInfoResponseEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadUInt32();
            Prof.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Target);
            Prof.Pack(writer);

        }


    }
}
