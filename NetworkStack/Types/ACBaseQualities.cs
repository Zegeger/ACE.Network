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
    /// Character properties.
    /// </summary>
    public class ACBaseQualities : IPackable
    {
        /// <summary>
        /// determines which property types appear in the message
        /// </summary>
        [MessageProperty]
        public uint Flags { get; set; }        
        
        /// <summary>
        /// Expect it always should be 0xA
        /// </summary>
        [MessageProperty]
        public ObjectType WeenieType { get; set; }        
        
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
        public PackableHashTable<DataPropertyID,int> DidStatsTable { get; } = new PackableHashTable<DataPropertyID,int>(ReadDidStatsTable, WriteDidStatsTable);
        
        [MessageProperty]
        public PackableHashTable<InstancePropertyID,uint> IidStatsTable { get; } = new PackableHashTable<InstancePropertyID,uint>(ReadIidStatsTable, WriteIidStatsTable);
        
        [MessageProperty]
        public PackableHashTable<PositionPropertyID,Position> PosStatsTable { get; } = new PackableHashTable<PositionPropertyID,Position>(ReadPosStatsTable, WritePosStatsTable);
        


        public void Unpack(BinaryReader reader)
        {
            Flags = reader.ReadUInt32();
            WeenieType = (ObjectType)reader.ReadUInt32();
            if((Flags & 0x00000001) != 0)
            {
                IntStatsTable.Unpack(reader);
            }
            if((Flags & 0x00000080) != 0)
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
            if((Flags & 0x00000010) != 0)
            {
                StrStatsTable.Unpack(reader);
            }
            if((Flags & 0x00000040) != 0)
            {
                DidStatsTable.Unpack(reader);
            }
            if((Flags & 0x00000008) != 0)
            {
                IidStatsTable.Unpack(reader);
            }
            if((Flags & 0x00000020) != 0)
            {
                PosStatsTable.Unpack(reader);
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Flags);
            writer.Write((uint)WeenieType);
            if((Flags & 0x00000001) != 0)
            {
                IntStatsTable.Pack(writer);
            }
            if((Flags & 0x00000080) != 0)
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
            if((Flags & 0x00000010) != 0)
            {
                StrStatsTable.Pack(writer);
            }
            if((Flags & 0x00000040) != 0)
            {
                DidStatsTable.Pack(writer);
            }
            if((Flags & 0x00000008) != 0)
            {
                IidStatsTable.Pack(writer);
            }
            if((Flags & 0x00000020) != 0)
            {
                PosStatsTable.Pack(writer);
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
        
        static KeyValuePair<DataPropertyID, int> ReadDidStatsTable(BinaryReader reader)
        {
            var key = (DataPropertyID)reader.ReadUInt32();
            var val = reader.ReadInt32();
            return new KeyValuePair<DataPropertyID, int>(key, val);
        }
        
        static void WriteDidStatsTable(BinaryWriter writer, KeyValuePair<DataPropertyID, int> pair)
        {
            writer.Write((uint)pair.Key);
            writer.Write(pair.Value);
        }
        
        static KeyValuePair<InstancePropertyID, uint> ReadIidStatsTable(BinaryReader reader)
        {
            var key = (InstancePropertyID)reader.ReadUInt32();
            var val = reader.ReadUInt32();
            return new KeyValuePair<InstancePropertyID, uint>(key, val);
        }
        
        static void WriteIidStatsTable(BinaryWriter writer, KeyValuePair<InstancePropertyID, uint> pair)
        {
            writer.Write((uint)pair.Key);
            writer.Write(pair.Value);
        }
        
        static KeyValuePair<PositionPropertyID, Position> ReadPosStatsTable(BinaryReader reader)
        {
            var key = (PositionPropertyID)reader.ReadUInt32();
            var val = new Position();
            val.Unpack(reader);
            return new KeyValuePair<PositionPropertyID, Position>(key, val);
        }
        
        static void WritePosStatsTable(BinaryWriter writer, KeyValuePair<PositionPropertyID, Position> pair)
        {
            writer.Write((uint)pair.Key);
            pair.Value.Pack(writer);
        }
        

    }
}
