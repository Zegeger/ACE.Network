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
    public class ArmorProfile : IPackable
    {
        /// <summary>
        /// relative protection against slashing damage (multiply by AL for actual protection)
        /// </summary>
        [MessageProperty]
        public float ProtSlashing { get; set; }        
        
        /// <summary>
        /// relative protection against piercing damage (multiply by AL for actual protection)
        /// </summary>
        [MessageProperty]
        public float ProtPiercing { get; set; }        
        
        /// <summary>
        /// relative protection against bludgeoning damage (multiply by AL for actual protection)
        /// </summary>
        [MessageProperty]
        public float ProtBludgeoning { get; set; }        
        
        /// <summary>
        /// relative protection against cold damage (multiply by AL for actual protection)
        /// </summary>
        [MessageProperty]
        public float ProtCold { get; set; }        
        
        /// <summary>
        /// relative protection against fire damage (multiply by AL for actual protection)
        /// </summary>
        [MessageProperty]
        public float ProtFire { get; set; }        
        
        /// <summary>
        /// relative protection against acid damage (multiply by AL for actual protection)
        /// </summary>
        [MessageProperty]
        public float ProtAcid { get; set; }        
        
        /// <summary>
        /// relative protection against nether damage (multiply by AL for actual protection)
        /// </summary>
        [MessageProperty]
        public float ProtNether { get; set; }        
        
        /// <summary>
        /// relative protection against lightning damage (multiply by AL for actual protection)
        /// </summary>
        [MessageProperty]
        public float ProtLightning { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            ProtSlashing = reader.ReadSingle();
            ProtPiercing = reader.ReadSingle();
            ProtBludgeoning = reader.ReadSingle();
            ProtCold = reader.ReadSingle();
            ProtFire = reader.ReadSingle();
            ProtAcid = reader.ReadSingle();
            ProtNether = reader.ReadSingle();
            ProtLightning = reader.ReadSingle();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(ProtSlashing);
            writer.Write(ProtPiercing);
            writer.Write(ProtBludgeoning);
            writer.Write(ProtCold);
            writer.Write(ProtFire);
            writer.Write(ProtAcid);
            writer.Write(ProtNether);
            writer.Write(ProtLightning);

        }


    }
}
