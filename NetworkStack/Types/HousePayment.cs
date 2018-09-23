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
    /// The HousePayment structure contains information about a house purchase or maintenance item.
    /// </summary>
    public class HousePayment : IPackable
    {
        /// <summary>
        /// the quantity required
        /// </summary>
        [MessageProperty]
        public uint Num { get; set; }        
        
        /// <summary>
        /// the quantity paid
        /// </summary>
        [MessageProperty]
        public uint Paid { get; set; }        
        
        /// <summary>
        /// the item's object type
        /// </summary>
        [MessageProperty]
        public uint Wcid { get; set; }        
        
        /// <summary>
        /// the name of this item
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        
        /// <summary>
        /// the plural name of this item (if not specified, use <name> followed by 's' or 'es')
        /// </summary>
        [MessageProperty]
        public string Pname { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Num = reader.ReadUInt32();
            Paid = reader.ReadUInt32();
            Wcid = reader.ReadUInt32();
            Name = reader.ReadString16L();
            Pname = reader.ReadString16L();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Num);
            writer.Write(Paid);
            writer.Write(Wcid);
            writer.WriteString16L(Name);
            writer.WriteString16L(Pname);

        }


    }
}
