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
    /// Set of information for a fellowship
    /// </summary>
    public class Fellowship : IPackable
    {
        /// <summary>
        /// Set of fellowship members with their ID as the key and some additional info for them
        /// </summary>
        [MessageProperty]
        public PackableHashTable<uint,Fellow> FellowshipTable { get; } = new PackableHashTable<uint,Fellow>(ReadFellowshipTable, WriteFellowshipTable);
        
        /// <summary>
        /// the fellowship name
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        
        /// <summary>
        /// the object ID of the fellowship leader
        /// </summary>
        [MessageProperty]
        public uint Leader { get; set; }        
        
        /// <summary>
        /// XP sharing: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public bool ShareXp { get; set; }        
        
        /// <summary>
        /// Even XP sharing: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public bool EvenXpSplit { get; set; }        
        
        /// <summary>
        /// Open fellowship: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public bool OpenFellow { get; set; }        
        
        /// <summary>
        /// Locked fellowship: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public bool Locked { get; set; }        
        
        /// <summary>
        /// I suspect this is a list of recently disconnected fellows which can be reinvited, even in locked fellowship
        /// </summary>
        [MessageProperty]
        public PackableHashTable<uint,int> FellowsDeparted { get; } = new PackableHashTable<uint,int>(ReadFellowsDeparted, WriteFellowsDeparted);
        


        public void Unpack(BinaryReader reader)
        {
            FellowshipTable.Unpack(reader);
            Name = reader.ReadString16L();
            Leader = reader.ReadUInt32();
            ShareXp = reader.ReadBool32();
            EvenXpSplit = reader.ReadBool32();
            OpenFellow = reader.ReadBool32();
            Locked = reader.ReadBool32();
            FellowsDeparted.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            FellowshipTable.Pack(writer);
            writer.WriteString16L(Name);
            writer.Write(Leader);
            writer.WriteBool32(ShareXp);
            writer.WriteBool32(EvenXpSplit);
            writer.WriteBool32(OpenFellow);
            writer.WriteBool32(Locked);
            FellowsDeparted.Pack(writer);

        }

        static KeyValuePair<uint, Fellow> ReadFellowshipTable(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = new Fellow();
            val.Unpack(reader);
            return new KeyValuePair<uint, Fellow>(key, val);
        }
        
        static void WriteFellowshipTable(BinaryWriter writer, KeyValuePair<uint, Fellow> pair)
        {
            writer.Write(pair.Key);
            pair.Value.Pack(writer);
        }
        
        static KeyValuePair<uint, int> ReadFellowsDeparted(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = reader.ReadInt32();
            return new KeyValuePair<uint, int>(key, val);
        }
        
        static void WriteFellowsDeparted(BinaryWriter writer, KeyValuePair<uint, int> pair)
        {
            writer.Write(pair.Key);
            writer.Write(pair.Value);
        }
        

    }
}
