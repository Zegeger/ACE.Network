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
    /// Set multiple character options.
    /// </summary>
    public class CharacterOptionsEventC2S : OrderedMessage
    {
        [MessageProperty]
        public PlayerModule Options { get; } = new PlayerModule();
        


        public CharacterOptionsEventC2S() : base((MessageType)0x01A1, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public CharacterOptionsEventC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Options.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Options.Pack(writer);

        }


    }
}
