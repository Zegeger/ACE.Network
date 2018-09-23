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
    /// Information describing your character.
    /// </summary>
    public class PlayerDescriptionS2C : OrderedMessage
    {
        [MessageProperty]
        public ACQualities Qualities { get; } = new ACQualities();
        
        [MessageProperty]
        public PlayerModule PlayerModule { get; } = new PlayerModule();
        
        /// <summary>
        /// Number of items in your main pack
        /// </summary>
        [MessageProperty]
        public PackableList<ContentProfile> ContentProfile { get; } = new PackableList<ContentProfile>(ReadContentProfile, WriteContentProfile);
        
        /// <summary>
        /// Items being equipt.
        /// </summary>
        [MessageProperty]
        public PackableList<InventoryPlacement> InventoryPlacement { get; } = new PackableList<InventoryPlacement>(ReadInventoryPlacement, WriteInventoryPlacement);
        


        public PlayerDescriptionS2C() : base((MessageType)0x0013, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PlayerDescriptionS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Qualities.Unpack(reader);
            PlayerModule.Unpack(reader);
            ContentProfile.Unpack(reader);
            InventoryPlacement.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Qualities.Pack(writer);
            PlayerModule.Pack(writer);
            ContentProfile.Pack(writer);
            InventoryPlacement.Pack(writer);

        }

        static ContentProfile ReadContentProfile(BinaryReader reader)
        {
            var item = new ContentProfile();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteContentProfile(BinaryWriter writer, ContentProfile item)
        {
            item.Pack(writer);
        }
        
        static InventoryPlacement ReadInventoryPlacement(BinaryReader reader)
        {
            var item = new InventoryPlacement();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteInventoryPlacement(BinaryWriter writer, InventoryPlacement item)
        {
            item.Pack(writer);
        }
        

    }
}
