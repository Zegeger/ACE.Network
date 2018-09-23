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
    /// Perform the allegiance house action
    /// </summary>
    public class DoAllegianceHouseActionC2S : OrderedMessage
    {
        /// <summary>
        /// Allegiance housing action to take
        /// </summary>
        [MessageProperty]
        public AllegianceHouseAction Action { get; set; }        
        


        public DoAllegianceHouseActionC2S() : base((MessageType)0x0042, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public DoAllegianceHouseActionC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Action = (AllegianceHouseAction)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Action);

        }


    }
}
