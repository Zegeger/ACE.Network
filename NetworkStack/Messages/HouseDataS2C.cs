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
    /// House panel information for owners.
    /// </summary>
    public class HouseDataS2C : OrderedMessage
    {
        /// <summary>
        /// the house data
        /// </summary>
        [MessageProperty]
        public HouseData Data { get; } = new HouseData();
        


        public HouseDataS2C() : base((MessageType)0x0225, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HouseDataS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Data.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Data.Pack(writer);

        }


    }
}
