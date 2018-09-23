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
    /// Friends list update
    /// </summary>
    public class FriendsUpdateS2C : OrderedMessage
    {
        /// <summary>
        /// The set of friend data for the player
        /// </summary>
        [MessageProperty]
        public PList<FriendData> Friends { get; } = new PList<FriendData>(ReadFriends, WriteFriends);
        
        /// <summary>
        /// The type of the update
        /// </summary>
        [MessageProperty]
        public FriendsUpdateType UpdateType { get; set; }        
        


        public FriendsUpdateS2C() : base((MessageType)0x0021, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public FriendsUpdateS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Friends.Unpack(reader);
            UpdateType = (FriendsUpdateType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            Friends.Pack(writer);
            writer.Write((uint)UpdateType);

        }

        static FriendData ReadFriends(BinaryReader reader)
        {
            var item = new FriendData();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteFriends(BinaryWriter writer, FriendData item)
        {
            item.Pack(writer);
        }
        

    }
}
