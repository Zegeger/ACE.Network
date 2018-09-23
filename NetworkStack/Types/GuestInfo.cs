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
    /// Set of information related to a house guest
    /// </summary>
    public class GuestInfo : IPackable
    {
        /// <summary>
        /// 0 is just access to house, 1 = access to storage
        /// </summary>
        [MessageProperty]
        public bool ItemStoragePermission { get; set; }        
        
        /// <summary>
        /// Name of the guest
        /// </summary>
        [MessageProperty]
        public string GuestName { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            ItemStoragePermission = reader.ReadBool32();
            GuestName = reader.ReadString16L();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(ItemStoragePermission);
            writer.WriteString16L(GuestName);

        }


    }
}
