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
    /// Data for an individual page
    /// </summary>
    public class PageData : IPackable
    {
        [MessageProperty]
        public uint AuthorID { get; set; }        
        
        [MessageProperty]
        public string AuthorName { get; set; }        
        
        [MessageProperty]
        public string AuthorAccount { get; set; }        
        
        [MessageProperty]
        public bool TextIncluded { get; set; }        
        
        [MessageProperty]
        public bool IgnoreAuthor { get; set; }        
        
        [MessageProperty]
        public string PageText { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            AuthorID = reader.ReadUInt32();
            AuthorName = reader.ReadString16L();
            AuthorAccount = reader.ReadString16L();
            var temp1 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 0xFFFF0002)
            {
                throw new Exception("Recieved value different from static on PageData, expected: 0xFFFF0002, actual " + temp1);
            }
#endif
            TextIncluded = reader.ReadBool32();
            IgnoreAuthor = reader.ReadBool32();
            if(TextIncluded)
            {
                PageText = reader.ReadString16L();
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(AuthorID);
            writer.WriteString16L(AuthorName);
            writer.WriteString16L(AuthorAccount);
            writer.Write((uint)0xFFFF0002); // Unused value
            writer.WriteBool32(TextIncluded);
            writer.WriteBool32(IgnoreAuthor);
            if(TextIncluded)
            {
                writer.WriteString16L(PageText);
            }

        }


    }
}
