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
    public class SquelchDB : IPackable
    {
        /// <summary>
        /// Account name and 
        /// </summary>
        [MessageProperty]
        public PackableHashTable<string,uint> AccountHash { get; } = new PackableHashTable<string,uint>(ReadAccountHash, WriteAccountHash);
        
        [MessageProperty]
        public PackableHashTable<uint,SquelchInfo> CharacterHash { get; } = new PackableHashTable<uint,SquelchInfo>(ReadCharacterHash, WriteCharacterHash);
        
        /// <summary>
        /// Global squelch information
        /// </summary>
        [MessageProperty]
        public SquelchInfo GlobalInfo { get; } = new SquelchInfo();
        


        public void Unpack(BinaryReader reader)
        {
            AccountHash.Unpack(reader);
            CharacterHash.Unpack(reader);
            GlobalInfo.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            AccountHash.Pack(writer);
            CharacterHash.Pack(writer);
            GlobalInfo.Pack(writer);

        }

        static KeyValuePair<string, uint> ReadAccountHash(BinaryReader reader)
        {
            var key = reader.ReadString16L();
            var val = reader.ReadUInt32();
            return new KeyValuePair<string, uint>(key, val);
        }
        
        static void WriteAccountHash(BinaryWriter writer, KeyValuePair<string, uint> pair)
        {
            writer.WriteString16L(pair.Key);
            writer.Write(pair.Value);
        }
        
        static KeyValuePair<uint, SquelchInfo> ReadCharacterHash(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = new SquelchInfo();
            val.Unpack(reader);
            return new KeyValuePair<uint, SquelchInfo>(key, val);
        }
        
        static void WriteCharacterHash(BinaryWriter writer, KeyValuePair<uint, SquelchInfo> pair)
        {
            writer.Write(pair.Key);
            pair.Value.Pack(writer);
        }
        

    }
}
