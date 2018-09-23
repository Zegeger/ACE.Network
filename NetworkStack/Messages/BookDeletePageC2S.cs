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
    /// Removes a page from a book
    /// </summary>
    public class BookDeletePageC2S : OrderedMessage
    {
        /// <summary>
        /// ID of book to remove a page from
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// Number of page to remove
        /// </summary>
        [MessageProperty]
        public int PageNum { get; set; }        
        


        public BookDeletePageC2S() : base((MessageType)0x00AD, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public BookDeletePageC2S(BinaryReader reader) : this()
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
