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
    /// Set of inventory items
    /// </summary>
    public class InventoryPlacement : IPackable
    {
        [MessageProperty]
        public uint Iid { get; set; }        
        
        [MessageProperty]
        public EquipMask Loc { get; set; }        
        
        [MessageProperty]
        public uint Priority { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Iid = reader.ReadUInt32();
            Loc = (EquipMask)reader.ReadUInt32();
            Priority = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Iid);
            writer.Write((uint)Loc);
            writer.Write(Priority);

        }


    }
}
