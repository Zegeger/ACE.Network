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
    /// Contains data for animation part changes
    /// </summary>
    public class AnimPartChange : IPackable
    {
        /// <summary>
        /// The index of the model
        /// </summary>
        [MessageProperty]
        public byte PartIndex { get; set; }        
        
        /// <summary>
        /// model DataID (minus 0x01000000)
        /// </summary>
        [MessageProperty]
        public uint PartID { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            PartIndex = reader.ReadByte();
            PartID = reader.ReadUIntCompressed16();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(PartIndex);
            writer.WriteUIntCompressed16(PartID);

        }


    }
}
