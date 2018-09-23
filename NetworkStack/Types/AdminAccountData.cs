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
    public class AdminAccountData : IPackable
    {
        [MessageProperty]
        public string AccountName { get; set; }        
        
        [MessageProperty]
        public uint BookieID { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            AccountName = reader.ReadString16L();
            BookieID = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(AccountName);
            writer.Write(BookieID);

        }


    }
}
