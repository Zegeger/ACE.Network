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
    /// Set Turbine Chat channel numbers.
    /// </summary>
    public class ChatRoomTrackerS2C : OrderedMessage
    {
        /// <summary>
        /// the channel number of the allegiance channel
        /// </summary>
        [MessageProperty]
        public uint AllegianceRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the general channel
        /// </summary>
        [MessageProperty]
        public uint GeneralChatRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the trade channel
        /// </summary>
        [MessageProperty]
        public uint TradeChatRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the looking-for-group channel
        /// </summary>
        [MessageProperty]
        public uint LFGChatRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the roleplay channel
        /// </summary>
        [MessageProperty]
        public uint RoleplayChatRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the olthoi channel
        /// </summary>
        [MessageProperty]
        public uint OlthoiChatRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the society channel
        /// </summary>
        [MessageProperty]
        public uint SocietyChatRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the Celestial Hand channel
        /// </summary>
        [MessageProperty]
        public uint SocietyCelHanChatRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the Eldrich Web channel
        /// </summary>
        [MessageProperty]
        public uint SocietyEldWebChatRoomID { get; set; }        
        
        /// <summary>
        /// the channel number of the Radiant Blood channel
        /// </summary>
        [MessageProperty]
        public uint SocietyRadBloChatRoomID { get; set; }        
        


        public ChatRoomTrackerS2C() : base((MessageType)0x0295, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ChatRoomTrackerS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            AllegianceRoomID = reader.ReadUInt32();
            GeneralChatRoomID = reader.ReadUInt32();
            TradeChatRoomID = reader.ReadUInt32();
            LFGChatRoomID = reader.ReadUInt32();
            RoleplayChatRoomID = reader.ReadUInt32();
            OlthoiChatRoomID = reader.ReadUInt32();
            SocietyChatRoomID = reader.ReadUInt32();
            SocietyCelHanChatRoomID = reader.ReadUInt32();
            SocietyEldWebChatRoomID = reader.ReadUInt32();
            SocietyRadBloChatRoomID = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(AllegianceRoomID);
            writer.Write(GeneralChatRoomID);
            writer.Write(TradeChatRoomID);
            writer.Write(LFGChatRoomID);
            writer.Write(RoleplayChatRoomID);
            writer.Write(OlthoiChatRoomID);
            writer.Write(SocietyChatRoomID);
            writer.Write(SocietyCelHanChatRoomID);
            writer.Write(SocietyEldWebChatRoomID);
            writer.Write(SocietyRadBloChatRoomID);

        }


    }
}
