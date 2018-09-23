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
    public class ChildInfo : IPackable
    {
        [MessageProperty]
        public uint ItemID { get; set; }        
        
        /// <summary>
        /// the slot in which this object is equipped, referenced in the Setup table of the dats
        /// </summary>
        [MessageProperty]
        public uint LocationID { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            ItemID = reader.ReadUInt32();
            LocationID = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(ItemID);
            writer.Write(LocationID);

        }


    }
}
