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
    /// Admin Receive Player Data
    /// </summary>
    public class ReceivePlayerDataS2C : Message
    {
        [MessageProperty]
        public int Unknown { get; set; }        
        
        /// <summary>
        /// Set of player data
        /// </summary>
        [MessageProperty]
        public PackableList<AdminPlayerData> AdminPlayerData { get; } = new PackableList<AdminPlayerData>(ReadAdminPlayerData, WriteAdminPlayerData);
        


        public ReceivePlayerDataS2C() : base((MessageType)0xF7CB, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ReceivePlayerDataS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Unknown = reader.ReadInt32();
            AdminPlayerData.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Unknown);
            AdminPlayerData.Pack(writer);

        }

        static AdminPlayerData ReadAdminPlayerData(BinaryReader reader)
        {
            var item = new AdminPlayerData();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteAdminPlayerData(BinaryWriter writer, AdminPlayerData item)
        {
            item.Pack(writer);
        }
        

    }
}
