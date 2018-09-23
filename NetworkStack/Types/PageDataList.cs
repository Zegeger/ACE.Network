////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// List of pages in a book
    /// </summary>
    public class PageDataList : IPackable
    {
        [MessageProperty]
        public uint MaxNumPages { get; set; }        
        
        [MessageProperty]
        public uint MaxNumCharsPerPage { get; set; }        
        
        /// <summary>
        /// List of pages
        /// </summary>
        [MessageProperty]
        public PackableList<PageData> Pages { get; } = new PackableList<PageData>(ReadPages, WritePages);
        


        public void Unpack(BinaryReader reader)
        {
            MaxNumPages = reader.ReadUInt32();
            MaxNumCharsPerPage = reader.ReadUInt32();
            Pages.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(MaxNumPages);
            writer.Write(MaxNumCharsPerPage);
            Pages.Pack(writer);

        }

        static PageData ReadPages(BinaryReader reader)
        {
            var item = new PageData();
            item.Unpack(reader);
            return item;
        }
        
        static void WritePages(BinaryWriter writer, PageData item)
        {
            item.Pack(writer);
        }
        

    }
}
