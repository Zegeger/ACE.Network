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
    /// Admin Receive Account Data
    /// </summary>
    public class ReceiveAccountDataS2C : Message
    {
        [MessageProperty]
        public uint Unknown { get; set; }        
        
        /// <summary>
        /// Set of account data
        /// </summary>
        [MessageProperty]
        public PackableList<AdminAccountData> AdminAccountData { get; } = new PackableList<AdminAccountData>(ReadAdminAccountData, WriteAdminAccountData);
        


        public ReceiveAccountDataS2C() : base((MessageType)0xF7CA, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ReceiveAccountDataS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Unknown = reader.ReadUInt32();
            AdminAccountData.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Unknown);
            AdminAccountData.Pack(writer);

        }

        static AdminAccountData ReadAdminAccountData(BinaryReader reader)
        {
            var item = new AdminAccountData();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteAdminAccountData(BinaryWriter writer, AdminAccountData item)
        {
            item.Pack(writer);
        }
        

    }
}
