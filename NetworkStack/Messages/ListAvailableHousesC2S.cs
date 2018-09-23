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
    /// Lists available house /house available
    /// </summary>
    public class ListAvailableHousesC2S : OrderedMessage
    {
        /// <summary>
        /// Type of house being listed
        /// </summary>
        [MessageProperty]
        public HouseType HouseType { get; set; }        
        


        public ListAvailableHousesC2S() : base((MessageType)0x0270, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ListAvailableHousesC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            HouseType = (HouseType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)HouseType);

        }


    }
}
