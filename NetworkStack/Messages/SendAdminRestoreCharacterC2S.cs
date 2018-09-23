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
    /// Admin command to restore a character
    /// </summary>
    public class SendAdminRestoreCharacterC2S : Message
    {
        /// <summary>
        /// ID of character to restore
        /// </summary>
        [MessageProperty]
        public uint Iid { get; set; }        
        
        /// <summary>
        /// Name of character to restore
        /// </summary>
        [MessageProperty]
        public string RestoredCharName { get; set; }        
        
        /// <summary>
        /// Account name to restore the character on
        /// </summary>
        [MessageProperty]
        public string AcctToRestoreTo { get; set; }        
        


        public SendAdminRestoreCharacterC2S() : base((MessageType)0xF7D9, MessageDirection.ClientToServer, (Queues)0x00000002)
        { }

        public SendAdminRestoreCharacterC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Iid = reader.ReadUInt32();
            RestoredCharName = reader.ReadString16L();
            AcctToRestoreTo = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Iid);
            writer.WriteString16L(RestoredCharName);
            writer.WriteString16L(AcctToRestoreTo);

        }


    }
}
