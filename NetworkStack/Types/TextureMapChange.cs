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
    /// Contains data for texture map changes
    /// </summary>
    public class TextureMapChange : IPackable
    {
        /// <summary>
        /// the index of the model we are replacing the texture in
        /// </summary>
        [MessageProperty]
        public byte PartIndex { get; set; }        
        
        /// <summary>
        /// texture DataID (minus 0x05000000)
        /// </summary>
        [MessageProperty]
        public uint OldTexID { get; set; }        
        
        /// <summary>
        /// texture DataID (minus 0x05000000)
        /// </summary>
        [MessageProperty]
        public uint NewTexID { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            PartIndex = reader.ReadByte();
            OldTexID = reader.ReadUIntCompressed16();
            NewTexID = reader.ReadUIntCompressed16();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(PartIndex);
            writer.WriteUIntCompressed16(OldTexID);
            writer.WriteUIntCompressed16(NewTexID);

        }


    }
}
