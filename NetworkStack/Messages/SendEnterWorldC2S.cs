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
    /// The character to log in.
    /// </summary>
    public class SendEnterWorldC2S : Message
    {
        /// <summary>
        /// The character ID of the character to log in
        /// </summary>
        [MessageProperty]
        public uint Gid { get; set; }        
        
        /// <summary>
        /// The account name associated with the character
        /// </summary>
        [MessageProperty]
        public string Account { get; set; }        
        


        public SendEnterWorldC2S() : base((MessageType)0xF657, MessageDirection.ClientToServer, (Queues)0x00000004)
        { }

        public SendEnterWorldC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Gid = reader.ReadUInt32();
            Account = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Gid);
            writer.WriteString16L(Account);

        }


    }
}
