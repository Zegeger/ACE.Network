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
    /// Contains the text of a single page of a book, parchment or sign.
    /// </summary>
    public class BookPageDataResponseS2C : OrderedMessage
    {
        /// <summary>
        /// The object id for the readable object.
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The 0-based index of the page you are currently viewing.
        /// </summary>
        [MessageProperty]
        public uint Page { get; set; }        
        
        [MessageProperty]
        public PageData PageData { get; } = new PageData();
        


        public BookPageDataResponseS2C() : base((MessageType)0x00B8, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public BookPageDataResponseS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            Page = reader.ReadUInt32();
            PageData.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(Page);
            PageData.Pack(writer);

        }


    }
}
