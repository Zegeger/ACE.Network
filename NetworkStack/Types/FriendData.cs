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
    public class FriendData : IPackable
    {
        /// <summary>
        /// Friend's ID
        /// </summary>
        [MessageProperty]
        public uint Id { get; set; }        
        
        /// <summary>
        /// Whether this friend is online
        /// </summary>
        [MessageProperty]
        public bool Online { get; set; }        
        
        /// <summary>
        /// Whether the friend should appear to be offline
        /// </summary>
        [MessageProperty]
        public bool AppearOffline { get; set; }        
        
        /// <summary>
        /// Name of the friend
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        
        /// <summary>
        /// The people on this player's friends list
        /// </summary>
        [MessageProperty]
        public PList<uint> Friends { get; } = new PList<uint>(ReadFriends, WriteFriends);
        
        /// <summary>
        /// The people who have this player on their friends list
        /// </summary>
        [MessageProperty]
        public PList<uint> FriendsOf { get; } = new PList<uint>(ReadFriendsOf, WriteFriendsOf);
        


        public void Unpack(BinaryReader reader)
        {
            Id = reader.ReadUInt32();
            Online = reader.ReadBool32();
            AppearOffline = reader.ReadBool32();
            Name = reader.ReadString16L();
            Friends.Unpack(reader);
            FriendsOf.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Id);
            writer.WriteBool32(Online);
            writer.WriteBool32(AppearOffline);
            writer.WriteString16L(Name);
            Friends.Pack(writer);
            FriendsOf.Pack(writer);

        }

        static uint ReadFriends(BinaryReader reader)
        {
            var item = reader.ReadUInt32();
            return item;
        }
        
        static void WriteFriends(BinaryWriter writer, uint item)
        {
            writer.Write(item);
        }
        
        static uint ReadFriendsOf(BinaryReader reader)
        {
            var item = reader.ReadUInt32();
            return item;
        }
        
        static void WriteFriendsOf(BinaryWriter writer, uint item)
        {
            writer.Write(item);
        }
        

    }
}
