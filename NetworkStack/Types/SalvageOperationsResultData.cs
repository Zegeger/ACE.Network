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
    /// Set of information related to a salvage operation
    /// </summary>
    public class SalvageOperationsResultData : IPackable
    {
        /// <summary>
        /// Which skill was used for the salvaging action
        /// </summary>
        [MessageProperty]
        public SkillID SkillUsed { get; set; }        
        
        /// <summary>
        /// Set of items that could not be salvaged
        /// </summary>
        [MessageProperty]
        public PackableList<uint> NotSalvagable { get; } = new PackableList<uint>(ReadNotSalvagable, WriteNotSalvagable);
        
        /// <summary>
        /// Set of salvage returned
        /// </summary>
        [MessageProperty]
        public PackableList<SalvageResult> SalvageResults { get; } = new PackableList<SalvageResult>(ReadSalvageResults, WriteSalvageResults);
        
        /// <summary>
        /// Amount of units due to your Ciandra's Fortune augmentation
        /// </summary>
        [MessageProperty]
        public int AugBonus { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            SkillUsed = (SkillID)reader.ReadUInt32();
            NotSalvagable.Unpack(reader);
            SalvageResults.Unpack(reader);
            AugBonus = reader.ReadInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)SkillUsed);
            NotSalvagable.Pack(writer);
            SalvageResults.Pack(writer);
            writer.Write(AugBonus);

        }

        static uint ReadNotSalvagable(BinaryReader reader)
        {
            var item = reader.ReadUInt32();
            return item;
        }
        
        static void WriteNotSalvagable(BinaryWriter writer, uint item)
        {
            writer.Write(item);
        }
        
        static SalvageResult ReadSalvageResults(BinaryReader reader)
        {
            var item = new SalvageResult();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteSalvageResults(BinaryWriter writer, SalvageResult item)
        {
            item.Pack(writer);
        }
        

    }
}
