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
    /// Contains information about a contract.
    /// </summary>
    public class ContractTracker : IPackable
    {
        [MessageProperty]
        public uint Version { get; set; }        
        
        [MessageProperty]
        public uint ContractID { get; set; }        
        
        [MessageProperty]
        public ContractStage ContractStage { get; set; }        
        
        [MessageProperty]
        public long TimeWhenDone { get; set; }        
        
        [MessageProperty]
        public long TimeWhenRepeats { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Version = reader.ReadUInt32();
            ContractID = reader.ReadUInt32();
            ContractStage = (ContractStage)reader.ReadUInt32();
            TimeWhenDone = reader.ReadInt64();
            TimeWhenRepeats = reader.ReadInt64();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Version);
            writer.Write(ContractID);
            writer.Write((uint)ContractStage);
            writer.Write(TimeWhenDone);
            writer.Write(TimeWhenRepeats);

        }


    }
}
