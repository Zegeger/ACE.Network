////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    /// <summary>
    /// The result of an attempt to assess an item or creature.
    /// </summary>
    public class SetAppraiseInfoS2C : OrderedMessage
    {
        /// <summary>
        /// the object ID of the item or creature being assessed
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        [MessageProperty]
        public uint Flags { get; set; }        
        
        /// <summary>
        /// assessment successful: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public bool Success { get; set; }        
        
        [MessageProperty]
        public PackableHashTable<IntPropertyID,int> IntStatsTable { get; } = new PackableHashTable<IntPropertyID,int>(ReadIntStatsTable, WriteIntStatsTable);
        
        [MessageProperty]
        public PackableHashTable<Int64PropertyID,long> Int64StatsTable { get; } = new PackableHashTable<Int64PropertyID,long>(ReadInt64StatsTable, WriteInt64StatsTable);
        
        [MessageProperty]
        public PackableHashTable<BooleanPropertyID,bool> BoolStatsTable { get; } = new PackableHashTable<BooleanPropertyID,bool>(ReadBoolStatsTable, WriteBoolStatsTable);
        
        [MessageProperty]
        public PackableHashTable<FloatPropertyID,double> FloatStatsTable { get; } = new PackableHashTable<FloatPropertyID,double>(ReadFloatStatsTable, WriteFloatStatsTable);
        
        [MessageProperty]
        public PackableHashTable<StringPropertyID,string> StrStatsTable { get; } = new PackableHashTable<StringPropertyID,string>(ReadStrStatsTable, WriteStrStatsTable);
        
        [MessageProperty]
        public PackableHashTable<DataPropertyID,uint> DidStatsTable { get; } = new PackableHashTable<DataPropertyID,uint>(ReadDidStatsTable, WriteDidStatsTable);
        
        [MessageProperty]
        public PSmartArray<LayeredSpellID> SpellBook { get; } = new PSmartArray<LayeredSpellID>(ReadSpellBook, WriteSpellBook);
        
        [MessageProperty]
        public ArmorProfile ArmorProfile { get; } = new ArmorProfile();
        
        [MessageProperty]
        public CreatureAppraisalProfile CreatureProfile { get; } = new CreatureAppraisalProfile();
        
        [MessageProperty]
        public WeaponProfile WeaponProfile { get; } = new WeaponProfile();
        
        [MessageProperty]
        public HookAppraisalProfile HookAppraisalProfile { get; } = new HookAppraisalProfile();
        
        /// <summary>
        /// highlight enable bitmask: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public ArmorHighlightMask ProtHighlight { get; set; }        
        
        /// <summary>
        /// highlight color bitmask: 0=red, 1=green
        /// </summary>
        [MessageProperty]
        public ArmorHighlightMask ProtColor { get; set; }        
        
        /// <summary>
        /// highlight enable bitmask: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public WeaponHighlightMask WeapHighlight { get; set; }        
        
        /// <summary>
        /// highlight color bitmask: 0=red, 1=green
        /// </summary>
        [MessageProperty]
        public WeaponHighlightMask WeapColor { get; set; }        
        
        /// <summary>
        /// highlight enable bitmask: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public ResistHighlightMask ResistHighlight { get; set; }        
        
        /// <summary>
        /// highlight color bitmask: 0=red, 1=green
        /// </summary>
        [MessageProperty]
        public ResistHighlightMask ResistColor { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorHead { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorChest { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorGroin { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorBicep { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorWrist { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorHand { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorThigh { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorShin { get; set; }        
        
        /// <summary>
        /// Armor level
        /// </summary>
        [MessageProperty]
        public uint BaseArmorFoot { get; set; }        
        


        public SetAppraiseInfoS2C() : base((MessageType)0x00C9, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public SetAppraiseInfoS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            Flags = reader.ReadUInt32();
            Success = reader.ReadBool32();
            if((Flags & 0x00000001) != 0)
            {
                IntStatsTable.Unpack(reader);
            }
            if((Flags & 0x00002000) != 0)
            {
                Int64StatsTable.Unpack(reader);
            }
            if((Flags & 0x00000002) != 0)
            {
                BoolStatsTable.Unpack(reader);
            }
            if((Flags & 0x00000004) != 0)
            {
                FloatStatsTable.Unpack(reader);
            }
            if((Flags & 0x00000008) != 0)
            {
                StrStatsTable.Unpack(reader);
            }
            if((Flags & 0x00001000) != 0)
            {
                DidStatsTable.Unpack(reader);
            }
            if((Flags & 0x00000010) != 0)
            {
                SpellBook.Unpack(reader);
            }
            if((Flags & 0x00000080) != 0)
            {
                ArmorProfile.Unpack(reader);
            }
            if((Flags & 0x00000100) != 0)
            {
                CreatureProfile.Unpack(reader);
            }
            if((Flags & 0x00000020) != 0)
            {
                WeaponProfile.Unpack(reader);
            }
            if((Flags & 0x00000040) != 0)
            {
                HookAppraisalProfile.Unpack(reader);
            }
            if((Flags & 0x00000200) != 0)
            {
                ProtHighlight = (ArmorHighlightMask)reader.ReadUInt16();
                ProtColor = (ArmorHighlightMask)reader.ReadUInt16();
            }
            if((Flags & 0x00000800) != 0)
            {
                WeapHighlight = (WeaponHighlightMask)reader.ReadUInt16();
                WeapColor = (WeaponHighlightMask)reader.ReadUInt16();
            }
            if((Flags & 0x00000400) != 0)
            {
                ResistHighlight = (ResistHighlightMask)reader.ReadUInt16();
                ResistColor = (ResistHighlightMask)reader.ReadUInt16();
            }
            if((Flags & 0x00004000) != 0)
            {
                BaseArmorHead = reader.ReadUInt32();
                BaseArmorChest = reader.ReadUInt32();
                BaseArmorGroin = reader.ReadUInt32();
                BaseArmorBicep = reader.ReadUInt32();
                BaseArmorWrist = reader.ReadUInt32();
                BaseArmorHand = reader.ReadUInt32();
                BaseArmorThigh = reader.ReadUInt32();
                BaseArmorShin = reader.ReadUInt32();
                BaseArmorFoot = reader.ReadUInt32();
            }

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(Flags);
            writer.WriteBool32(Success);
            if((Flags & 0x00000001) != 0)
            {
                IntStatsTable.Pack(writer);
            }
            if((Flags & 0x00002000) != 0)
            {
                Int64StatsTable.Pack(writer);
            }
            if((Flags & 0x00000002) != 0)
            {
                BoolStatsTable.Pack(writer);
            }
            if((Flags & 0x00000004) != 0)
            {
                FloatStatsTable.Pack(writer);
            }
            if((Flags & 0x00000008) != 0)
            {
                StrStatsTable.Pack(writer);
            }
            if((Flags & 0x00001000) != 0)
            {
                DidStatsTable.Pack(writer);
            }
            if((Flags & 0x00000010) != 0)
            {
                SpellBook.Pack(writer);
            }
            if((Flags & 0x00000080) != 0)
            {
                ArmorProfile.Pack(writer);
            }
            if((Flags & 0x00000100) != 0)
            {
                CreatureProfile.Pack(writer);
            }
            if((Flags & 0x00000020) != 0)
            {
                WeaponProfile.Pack(writer);
            }
            if((Flags & 0x00000040) != 0)
            {
                HookAppraisalProfile.Pack(writer);
            }
            if((Flags & 0x00000200) != 0)
            {
                writer.Write((ushort)ProtHighlight);
                writer.Write((ushort)ProtColor);
            }
            if((Flags & 0x00000800) != 0)
            {
                writer.Write((ushort)WeapHighlight);
                writer.Write((ushort)WeapColor);
            }
            if((Flags & 0x00000400) != 0)
            {
                writer.Write((ushort)ResistHighlight);
                writer.Write((ushort)ResistColor);
            }
            if((Flags & 0x00004000) != 0)
            {
                writer.Write(BaseArmorHead);
                writer.Write(BaseArmorChest);
                writer.Write(BaseArmorGroin);
                writer.Write(BaseArmorBicep);
                writer.Write(BaseArmorWrist);
                writer.Write(BaseArmorHand);
                writer.Write(BaseArmorThigh);
                writer.Write(BaseArmorShin);
                writer.Write(BaseArmorFoot);
            }

        }

        static KeyValuePair<IntPropertyID, int> ReadIntStatsTable(BinaryReader reader)
        {
            var key = (IntPropertyID)reader.ReadUInt32();
            var val = reader.ReadInt32();
            return new KeyValuePair<IntPropertyID, int>(key, val);
        }
        
        static void WriteIntStatsTable(BinaryWriter writer, KeyValuePair<IntPropertyID, int> pair)
        {
            writer.Write((uint)pair.Key);
            writer.Write(pair.Value);
        }
        
        static KeyValuePair<Int64PropertyID, long> ReadInt64StatsTable(BinaryReader reader)
        {
            var key = (Int64PropertyID)reader.ReadUInt32();
            var val = reader.ReadInt64();
            return new KeyValuePair<Int64PropertyID, long>(key, val);
        }
        
        static void WriteInt64StatsTable(BinaryWriter writer, KeyValuePair<Int64PropertyID, long> pair)
        {
            writer.Write((uint)pair.Key);
            writer.Write(pair.Value);
        }
        
        static KeyValuePair<BooleanPropertyID, bool> ReadBoolStatsTable(BinaryReader reader)
        {
            var key = (BooleanPropertyID)reader.ReadUInt32();
            var val = reader.ReadBool32();
            return new KeyValuePair<BooleanPropertyID, bool>(key, val);
        }
        
        static void WriteBoolStatsTable(BinaryWriter writer, KeyValuePair<BooleanPropertyID, bool> pair)
        {
            writer.Write((uint)pair.Key);
            writer.WriteBool32(pair.Value);
        }
        
        static KeyValuePair<FloatPropertyID, double> ReadFloatStatsTable(BinaryReader reader)
        {
            var key = (FloatPropertyID)reader.ReadUInt32();
            var val = reader.ReadDouble();
            return new KeyValuePair<FloatPropertyID, double>(key, val);
        }
        
        static void WriteFloatStatsTable(BinaryWriter writer, KeyValuePair<FloatPropertyID, double> pair)
        {
            writer.Write((uint)pair.Key);
            writer.Write(pair.Value);
        }
        
        static KeyValuePair<StringPropertyID, string> ReadStrStatsTable(BinaryReader reader)
        {
            var key = (StringPropertyID)reader.ReadUInt32();
            var val = reader.ReadString16L();
            return new KeyValuePair<StringPropertyID, string>(key, val);
        }
        
        static void WriteStrStatsTable(BinaryWriter writer, KeyValuePair<StringPropertyID, string> pair)
        {
            writer.Write((uint)pair.Key);
            writer.WriteString16L(pair.Value);
        }
        
        static KeyValuePair<DataPropertyID, uint> ReadDidStatsTable(BinaryReader reader)
        {
            var key = (DataPropertyID)reader.ReadUInt32();
            var val = reader.ReadUInt32();
            return new KeyValuePair<DataPropertyID, uint>(key, val);
        }
        
        static void WriteDidStatsTable(BinaryWriter writer, KeyValuePair<DataPropertyID, uint> pair)
        {
            writer.Write((uint)pair.Key);
            writer.Write(pair.Value);
        }
        
        static LayeredSpellID ReadSpellBook(BinaryReader reader)
        {
            var item = new LayeredSpellID();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteSpellBook(BinaryWriter writer, LayeredSpellID item)
        {
            item.Pack(writer);
        }
        

    }
}
