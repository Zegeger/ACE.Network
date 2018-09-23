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
    /// Allegience hierarchy information
    /// </summary>
    public class AllegianceHierarchy : IPackable
    {
        /// <summary>
        /// Number of character allegiance records.
        /// </summary>
        [MessageProperty]
        public ushort RecordCount { get; set; }        
        
        /// <summary>
        /// Taking a guess on these values.  Guessing they may only be valid on Monarchs.
        /// </summary>
        [MessageProperty]
        public PHashTable<uint,AllegianceOfficerLevel> Officers { get; } = new PHashTable<uint,AllegianceOfficerLevel>(ReadOfficers, WriteOfficers);
        
        /// <summary>
        /// Believe these may pass in the current officer title list.  Guessing they may only be valid on Monarchs.
        /// </summary>
        [MessageProperty]
        public PSmartArray<string> OfficerTitles { get; } = new PSmartArray<string>(ReadOfficerTitles, WriteOfficerTitles);
        
        /// <summary>
        /// May only be valid for Monarchs/Speakers?
        /// </summary>
        [MessageProperty]
        public int MonarchBroadcastTime { get; set; }        
        
        /// <summary>
        /// May only be valid for Monarchs/Speakers?
        /// </summary>
        [MessageProperty]
        public uint MonarchBroadcastsToday { get; set; }        
        
        /// <summary>
        /// May only be valid for Monarchs/Speakers?
        /// </summary>
        [MessageProperty]
        public int SpokesBroadcastTime { get; set; }        
        
        /// <summary>
        /// May only be valid for Monarchs/Speakers?
        /// </summary>
        [MessageProperty]
        public uint SpokesBroadcastsToday { get; set; }        
        
        /// <summary>
        /// Text for current motd. May only be valid for Monarchs/Speakers?
        /// </summary>
        [MessageProperty]
        public string Motd { get; set; }        
        
        /// <summary>
        /// Who set the current motd. May only be valid for Monarchs/Speakers?
        /// </summary>
        [MessageProperty]
        public string MotdSetBy { get; set; }        
        
        /// <summary>
        /// allegiance chat channel number
        /// </summary>
        [MessageProperty]
        public uint ChatRoomID { get; set; }        
        
        /// <summary>
        /// Location of monarchy bindpoint
        /// </summary>
        [MessageProperty]
        public Position Bindpoint { get; } = new Position();
        
        /// <summary>
        /// The name of the allegiance.
        /// </summary>
        [MessageProperty]
        public string AllegianceName { get; set; }        
        
        /// <summary>
        /// Time name was last set.  Seems to count upward for some reason.
        /// </summary>
        [MessageProperty]
        public int NameLastSetTime { get; set; }        
        
        /// <summary>
        /// Whether allegiance is locked.
        /// </summary>
        [MessageProperty]
        public bool IsLocked { get; set; }        
        
        [MessageProperty]
        public uint ApprovedVassal { get; set; }        
        
        /// <summary>
        /// Monarch's data
        /// </summary>
        [MessageProperty]
        public AllegianceData MonarchData { get; } = new AllegianceData();
        
        /// <summary>
        /// Data for remaining people, which I believe should be your vassels.
        /// </summary>
        [MessageProperty]
        public List<AllegianceNode> Records { get; } = new List<AllegianceNode>();
        


        public void Unpack(BinaryReader reader)
        {
            RecordCount = reader.ReadUInt16();
            var temp1 = reader.ReadUInt16(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 0x000B)
            {
                throw new Exception("Recieved value different from static on AllegianceHierarchy, expected: 0x000B, actual " + temp1);
            }
#endif
            Officers.Unpack(reader);
            OfficerTitles.Unpack(reader);
            MonarchBroadcastTime = reader.ReadInt32();
            MonarchBroadcastsToday = reader.ReadUInt32();
            SpokesBroadcastTime = reader.ReadInt32();
            SpokesBroadcastsToday = reader.ReadUInt32();
            Motd = reader.ReadString16L();
            MotdSetBy = reader.ReadString16L();
            ChatRoomID = reader.ReadUInt32();
            Bindpoint.Unpack(reader);
            AllegianceName = reader.ReadString16L();
            NameLastSetTime = reader.ReadInt32();
            IsLocked = reader.ReadBool32();
            ApprovedVassal = reader.ReadUInt32();
            if(RecordCount > 0)
            {
                MonarchData.Unpack(reader);
                Records.Clear();
                for(int i = 0; i < RecordCount - 1; i++)
                {
                    AllegianceNode newItem = new AllegianceNode();
                    newItem.Unpack(reader);
                    Records.Add(newItem);
                }
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(RecordCount);
            writer.Write((ushort)0x000B); // Unused value
            Officers.Pack(writer);
            OfficerTitles.Pack(writer);
            writer.Write(MonarchBroadcastTime);
            writer.Write(MonarchBroadcastsToday);
            writer.Write(SpokesBroadcastTime);
            writer.Write(SpokesBroadcastsToday);
            writer.WriteString16L(Motd);
            writer.WriteString16L(MotdSetBy);
            writer.Write(ChatRoomID);
            Bindpoint.Pack(writer);
            writer.WriteString16L(AllegianceName);
            writer.Write(NameLastSetTime);
            writer.WriteBool32(IsLocked);
            writer.Write(ApprovedVassal);
            if(RecordCount > 0)
            {
                MonarchData.Pack(writer);
                for(int i = 0; i < RecordCount - 1; i++)
                {
                    Records[i].Pack(writer);
                }
            }

        }

        static KeyValuePair<uint, AllegianceOfficerLevel> ReadOfficers(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = (AllegianceOfficerLevel)reader.ReadUInt32();
            return new KeyValuePair<uint, AllegianceOfficerLevel>(key, val);
        }
        
        static void WriteOfficers(BinaryWriter writer, KeyValuePair<uint, AllegianceOfficerLevel> pair)
        {
            writer.Write(pair.Key);
            writer.Write((uint)pair.Value);
        }
        
        static string ReadOfficerTitles(BinaryReader reader)
        {
            var item = reader.ReadString16L();
            return item;
        }
        
        static void WriteOfficerTitles(BinaryWriter writer, string item)
        {
            writer.WriteString16L(item);
        }
        

    }
}
