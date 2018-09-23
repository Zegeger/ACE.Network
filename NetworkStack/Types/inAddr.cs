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
    /// Structure representing an IP Address
    /// </summary>
    public class inAddr : IPackable
    {
        /// <summary>
        /// First octet
        /// </summary>
        [MessageProperty]
        public byte B1 { get; set; }        
        
        /// <summary>
        /// Second octet
        /// </summary>
        [MessageProperty]
        public byte B2 { get; set; }        
        
        /// <summary>
        /// Third octet
        /// </summary>
        [MessageProperty]
        public byte B3 { get; set; }        
        
        /// <summary>
        /// Fourth octet
        /// </summary>
        [MessageProperty]
        public byte B4 { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            B1 = reader.ReadByte();
            B2 = reader.ReadByte();
            B3 = reader.ReadByte();
            B4 = reader.ReadByte();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(B1);
            writer.Write(B2);
            writer.Write(B3);
            writer.Write(B4);

        }


    }
}
