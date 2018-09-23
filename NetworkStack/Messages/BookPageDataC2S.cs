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
    /// Requests data for a page in a book
    /// </summary>
    public class BookPageDataC2S : OrderedMessage
    {
        /// <summary>
        /// ID of book
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// Number of page to get data for
        /// </summary>
        [MessageProperty]
        public int PageNum { get; set; }        
        


        public BookPageDataC2S() : base((MessageType)0x00AE, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public BookPageDataC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            PageNum = reader.ReadInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(PageNum);

        }


    }
}
