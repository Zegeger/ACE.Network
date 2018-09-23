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
    public class GeneratorRegistryNode : IPackable
    {
        [MessageProperty]
        public uint WcidOrTtype { get; set; }        
        
        [MessageProperty]
        public double Ts { get; set; }        
        
        [MessageProperty]
        public uint TreasureType { get; set; }        
        
        [MessageProperty]
        public uint Slot { get; set; }        
        
        [MessageProperty]
        public uint Checkpointed { get; set; }        
        
        [MessageProperty]
        public uint Shop { get; set; }        
        
        [MessageProperty]
        public uint Amount { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            WcidOrTtype = reader.ReadUInt32();
            Ts = reader.ReadDouble();
            TreasureType = reader.ReadUInt32();
            Slot = reader.ReadUInt32();
            Checkpointed = reader.ReadUInt32();
            Shop = reader.ReadUInt32();
            Amount = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(WcidOrTtype);
            writer.Write(Ts);
            writer.Write(TreasureType);
            writer.Write(Slot);
            writer.Write(Checkpointed);
            writer.Write(Shop);
            writer.Write(Amount);

        }


    }
}
