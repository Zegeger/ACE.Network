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
    /// Set of allegiance data for a specific player
    /// </summary>
    public class AllegianceData : IPackable
    {
        /// <summary>
        /// Character ID
        /// </summary>
        [MessageProperty]
        public uint CharacterID { get; set; }        
        
        /// <summary>
        /// XP gained while logged off
        /// </summary>
        [MessageProperty]
        public uint CpCached { get; set; }        
        
        /// <summary>
        /// Total allegiance XP contribution.
        /// </summary>
        [MessageProperty]
        public uint CpTithed { get; set; }        
        
        [MessageProperty]
        public uint Bitfield { get; set; }        
        
        /// <summary>
        /// The gender of the character (for determining title).
        /// </summary>
        [MessageProperty]
        public Gender Gender { get; set; }        
        
        /// <summary>
        /// The heritage of the character (for determining title).
        /// </summary>
        [MessageProperty]
        public HeritageGroup Hg { get; set; }        
        
        /// <summary>
        /// The numerical rank (1 is lowest).
        /// </summary>
        [MessageProperty]
        public ushort Rank { get; set; }        
        
        [MessageProperty]
        public uint Level { get; set; }        
        
        /// <summary>
        /// Character loyalty.
        /// </summary>
        [MessageProperty]
        public ushort Loyalty { get; set; }        
        
        /// <summary>
        /// Character leadership.
        /// </summary>
        [MessageProperty]
        public ushort Leadership { get; set; }        
        
        [MessageProperty]
        public ulong TimeOnline { get; set; }        
        
        [MessageProperty]
        public uint AllegianceAge { get; set; }        
        
        [MessageProperty]
        public string Name { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            CharacterID = reader.ReadUInt32();
            CpCached = reader.ReadUInt32();
            CpTithed = reader.ReadUInt32();
            Bitfield = reader.ReadUInt32();
            Gender = (Gender)reader.ReadByte();
            Hg = (HeritageGroup)reader.ReadByte();
            Rank = reader.ReadUInt16();
            if((Bitfield & 0x8) != 0)
            {
                Level = reader.ReadUInt32();
            }
            Loyalty = reader.ReadUInt16();
            Leadership = reader.ReadUInt16();
            if(Bitfield == 0x4)
            {
                TimeOnline = reader.ReadUInt64();
            }
            else
            {
                TimeOnline = reader.ReadUInt32();
                AllegianceAge = reader.ReadUInt32();
            }
            Name = reader.ReadString16L();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(CharacterID);
            writer.Write(CpCached);
            writer.Write(CpTithed);
            writer.Write(Bitfield);
            writer.Write((byte)Gender);
            writer.Write((byte)Hg);
            writer.Write(Rank);
            if((Bitfield & 0x8) != 0)
            {
                writer.Write(Level);
            }
            writer.Write(Loyalty);
            writer.Write(Leadership);
            if(Bitfield == 0x4)
            {
                writer.Write(TimeOnline);
            }
            else
            {
                writer.Write(TimeOnline);
                writer.Write(AllegianceAge);
            }
            writer.WriteString16L(Name);

        }


    }
}
