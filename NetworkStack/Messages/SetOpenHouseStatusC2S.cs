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
    /// Sets your house open status
    /// </summary>
    public class SetOpenHouseStatusC2S : OrderedMessage
    {
        /// <summary>
        /// Whether the house is open or not
        /// </summary>
        [MessageProperty]
        public bool OpenHouse { get; set; }        
        


        public SetOpenHouseStatusC2S() : base((MessageType)0x0247, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetOpenHouseStatusC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            OpenHouse = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(OpenHouse);

        }


    }
}
