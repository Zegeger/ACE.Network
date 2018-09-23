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
    /// Character creation result
    /// </summary>
    public class SendCharGenResultC2S : Message
    {
        /// <summary>
        /// The account for the character
        /// </summary>
        [MessageProperty]
        public string Account { get; set; }        
        
        /// <summary>
        /// The data for the character generation
        /// </summary>
        [MessageProperty]
        public CharGenResult CharGenResult { get; } = new CharGenResult();
        


        public SendCharGenResultC2S() : base((MessageType)0xF656, MessageDirection.ClientToServer, (Queues)0x00000004)
        { }

        public SendCharGenResultC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Account = reader.ReadString16L();
            CharGenResult.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(Account);
            CharGenResult.Pack(writer);

        }


    }
}
