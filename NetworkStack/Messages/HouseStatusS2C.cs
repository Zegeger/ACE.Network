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
    /// House Data
    /// </summary>
    public class HouseStatusS2C : OrderedMessage
    {
        /// <summary>
        /// Type of message to display
        /// </summary>
        [MessageProperty]
        public uint NoticeType { get; set; }        
        


        public HouseStatusS2C() : base((MessageType)0x0226, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HouseStatusS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            NoticeType = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(NoticeType);

        }


    }
}
