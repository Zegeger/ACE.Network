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
    /// Set information about an item for creation
    /// </summary>
    public class CreationProfile : IPackable
    {
        [MessageProperty]
        public uint Wcid { get; set; }        
        
        [MessageProperty]
        public uint Palette { get; set; }        
        
        [MessageProperty]
        public float Shade { get; set; }        
        
        [MessageProperty]
        public uint Destination { get; set; }        
        
        [MessageProperty]
        public int StackSize { get; set; }        
        
        [MessageProperty]
        public bool TryToBond { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Wcid = reader.ReadUInt32();
            Palette = reader.ReadUInt32();
            Shade = reader.ReadSingle();
            Destination = reader.ReadUInt32();
            StackSize = reader.ReadInt32();
            TryToBond = reader.ReadBool32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Wcid);
            writer.Write(Palette);
            writer.Write(Shade);
            writer.Write(Destination);
            writer.Write(StackSize);
            writer.WriteBool32(TryToBond);

        }


    }
}
