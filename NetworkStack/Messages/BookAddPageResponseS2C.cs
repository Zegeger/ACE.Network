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
    /// Response to an attempt to add a page to a book.
    /// </summary>
    public class BookAddPageResponseS2C : OrderedMessage
    {
        /// <summary>
        /// The readable object being changed.
        /// </summary>
        [MessageProperty]
        public uint BookID { get; set; }        
        
        /// <summary>
        /// The number the of page being added in the book.
        /// </summary>
        [MessageProperty]
        public uint PageNumber { get; set; }        
        
        /// <summary>
        /// Whether the request was successful
        /// </summary>
        [MessageProperty]
        public bool Success { get; set; }        
        


        public BookAddPageResponseS2C() : base((MessageType)0x00B6, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public BookAddPageResponseS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            BookID = reader.ReadUInt32();
            PageNumber = reader.ReadUInt32();
            Success = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(BookID);
            writer.Write(PageNumber);
            writer.WriteBool32(Success);

        }


    }
}
