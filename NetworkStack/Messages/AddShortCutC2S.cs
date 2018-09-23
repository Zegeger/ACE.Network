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
    /// Add an item to the shortcut bar.
    /// </summary>
    public class AddShortCutC2S : OrderedMessage
    {
        /// <summary>
        /// Shortcut information
        /// </summary>
        [MessageProperty]
        public ShortCutData ScData { get; } = new ShortCutData();
        


        public AddShortCutC2S() : base((MessageType)0x019C, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AddShortCutC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ScData.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            ScData.Pack(writer);

        }


    }
}
