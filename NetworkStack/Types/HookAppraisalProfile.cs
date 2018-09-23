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
    public class HookAppraisalProfile : IPackable
    {
        [MessageProperty]
        public HookAppraisalFlags HookBitfield { get; set; }        
        
        [MessageProperty]
        public uint HookValidLocations { get; set; }        
        
        [MessageProperty]
        public AmmoType HookAmmoType { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            HookBitfield = (HookAppraisalFlags)reader.ReadUInt32();
            HookValidLocations = reader.ReadUInt32();
            HookAmmoType = (AmmoType)reader.ReadUInt16();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)HookBitfield);
            writer.Write(HookValidLocations);
            writer.Write((ushort)HookAmmoType);

        }


    }
}
