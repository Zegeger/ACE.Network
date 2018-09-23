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
    /// Boots a player from the allegiance, optionally all characters on their account
    /// </summary>
    public class BreakAllegianceBootC2S : OrderedMessage
    {
        /// <summary>
        /// Name of character to boot
        /// </summary>
        [MessageProperty]
        public string BooteeName { get; set; }        
        
        /// <summary>
        /// Whether to boot all characters on their account
        /// </summary>
        [MessageProperty]
        public bool AccountBoot { get; set; }        
        


        public BreakAllegianceBootC2S() : base((MessageType)0x0277, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public BreakAllegianceBootC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            BooteeName = reader.ReadString16L();
            AccountBoot = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(BooteeName);
            writer.WriteBool32(AccountBoot);

        }


    }
}
