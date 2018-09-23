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
    /// Sent when you first open a book, contains the entire table of contents.
    /// </summary>
    public class BookOpenS2C : OrderedMessage
    {
        /// <summary>
        /// The readable object you have just opened.
        /// </summary>
        [MessageProperty]
        public uint BookID { get; set; }        
        
        /// <summary>
        /// The total number of pages in the book.
        /// </summary>
        [MessageProperty]
        public uint MaxNumPages { get; set; }        
        
        /// <summary>
        /// The set of page data
        /// </summary>
        [MessageProperty]
        public PageDataList PageData { get; } = new PageDataList();
        
        /// <summary>
        /// The inscription comment and the book title.
        /// </summary>
        [MessageProperty]
        public string Inscription { get; set; }        
        
        /// <summary>
        /// The author of the inscription (and not coincidentally, the book title).
        /// </summary>
        [MessageProperty]
        public uint ScribeId { get; set; }        
        
        /// <summary>
        /// The name of the inscription author.
        /// </summary>
        [MessageProperty]
        public string ScribeName { get; set; }        
        


        public BookOpenS2C() : base((MessageType)0x00B4, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public BookOpenS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            BookID = reader.ReadUInt32();
            MaxNumPages = reader.ReadUInt32();
            PageData.Unpack(reader);
            Inscription = reader.ReadString16L();
            ScribeId = reader.ReadUInt32();
            ScribeName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(BookID);
            writer.Write(MaxNumPages);
            PageData.Pack(writer);
            writer.WriteString16L(Inscription);
            writer.Write(ScribeId);
            writer.WriteString16L(ScribeName);

        }


    }
}
