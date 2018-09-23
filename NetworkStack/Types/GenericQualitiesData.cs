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
    public class GenericQualitiesData : IPackable
    {
        [MessageProperty]
        public uint Flags { get; set; }        
        
        [MessageProperty]
        public PackableHashTable<uint,uint> OptionInts { get; } = new PackableHashTable<uint,uint>(ReadOptionInts, WriteOptionInts);
        
        [MessageProperty]
        public PackableHashTable<uint,bool> OptionBools { get; } = new PackableHashTable<uint,bool>(ReadOptionBools, WriteOptionBools);
        
        [MessageProperty]
        public PackableHashTable<uint,float> OptionFloats { get; } = new PackableHashTable<uint,float>(ReadOptionFloats, WriteOptionFloats);
        
        [MessageProperty]
        public PackableHashTable<uint,string> OptionStrings { get; } = new PackableHashTable<uint,string>(ReadOptionStrings, WriteOptionStrings);
        


        public void Unpack(BinaryReader reader)
        {
            Flags = reader.ReadUInt32();
            if((Flags & 0x00000001) != 0)
            {
                OptionInts.Unpack(reader);
            }
            if((Flags & 0x00000002) != 0)
            {
                OptionBools.Unpack(reader);
            }
            if((Flags & 0x00000004) != 0)
            {
                OptionFloats.Unpack(reader);
            }
            if((Flags & 0x00000008) != 0)
            {
                OptionStrings.Unpack(reader);
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Flags);
            if((Flags & 0x00000001) != 0)
            {
                OptionInts.Pack(writer);
            }
            if((Flags & 0x00000002) != 0)
            {
                OptionBools.Pack(writer);
            }
            if((Flags & 0x00000004) != 0)
            {
                OptionFloats.Pack(writer);
            }
            if((Flags & 0x00000008) != 0)
            {
                OptionStrings.Pack(writer);
            }

        }

        static KeyValuePair<uint, uint> ReadOptionInts(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = reader.ReadUInt32();
            return new KeyValuePair<uint, uint>(key, val);
        }
        
        static void WriteOptionInts(BinaryWriter writer, KeyValuePair<uint, uint> pair)
        {
            writer.Write(pair.Key);
            writer.Write(pair.Value);
        }
        
        static KeyValuePair<uint, bool> ReadOptionBools(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = reader.ReadBool32();
            return new KeyValuePair<uint, bool>(key, val);
        }
        
        static void WriteOptionBools(BinaryWriter writer, KeyValuePair<uint, bool> pair)
        {
            writer.Write(pair.Key);
            writer.WriteBool32(pair.Value);
        }
        
        static KeyValuePair<uint, float> ReadOptionFloats(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = reader.ReadSingle();
            return new KeyValuePair<uint, float>(key, val);
        }
        
        static void WriteOptionFloats(BinaryWriter writer, KeyValuePair<uint, float> pair)
        {
            writer.Write(pair.Key);
            writer.Write(pair.Value);
        }
        
        static KeyValuePair<uint, string> ReadOptionStrings(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = reader.ReadString16L();
            return new KeyValuePair<uint, string>(key, val);
        }
        
        static void WriteOptionStrings(BinaryWriter writer, KeyValuePair<uint, string> pair)
        {
            writer.Write(pair.Key);
            writer.WriteString16L(pair.Value);
        }
        

    }
}
