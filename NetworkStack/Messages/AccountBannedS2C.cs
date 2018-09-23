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
    /// Account has been banned
    /// </summary>
    public class AccountBannedS2C : Message
    {
        /// <summary>
        /// Timestamp when ban expires, or 0 for permaban
        /// </summary>
        [MessageProperty]
        public uint BannedUntil { get; set; }        
        
        /// <summary>
        /// I believe this will be empty (len=1) in current version
        /// </summary>
        [MessageProperty]
        public string OldText { get; set; }        
        


        public AccountBannedS2C() : base((MessageType)0xF7C1, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AccountBannedS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            BannedUntil = reader.ReadUInt32();
            OldText = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(BannedUntil);
            writer.WriteString16L(OldText);

        }


    }
}
