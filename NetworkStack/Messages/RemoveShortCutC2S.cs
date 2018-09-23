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
    /// Remove an item from the shortcut bar.
    /// </summary>
    public class RemoveShortCutC2S : OrderedMessage
    {
        /// <summary>
        /// Position on the shortcut bar (0-8) of the item to be removed
        /// </summary>
        [MessageProperty]
        public uint Index { get; set; }        
        


        public RemoveShortCutC2S() : base((MessageType)0x019D, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public RemoveShortCutC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Index = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Index);

        }


    }
}
