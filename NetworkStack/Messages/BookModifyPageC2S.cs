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
    /// Updates a page in a book
    /// </summary>
    public class BookModifyPageC2S : OrderedMessage
    {
        /// <summary>
        /// ID of book
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// Number of page being updated
        /// </summary>
        [MessageProperty]
        public int PageNum { get; set; }        
        
        /// <summary>
        /// New text for the page
        /// </summary>
        [MessageProperty]
        public string PageText { get; set; }        
        


        public BookModifyPageC2S() : base((MessageType)0x00AB, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public BookModifyPageC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            PageNum = reader.ReadInt32();
            PageText = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(PageNum);
            writer.WriteString16L(PageText);

        }


    }
}
