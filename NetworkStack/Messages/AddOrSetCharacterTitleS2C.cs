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
    /// Set a title for the current character.
    /// </summary>
    public class AddOrSetCharacterTitleS2C : OrderedMessage
    {
        /// <summary>
        /// the title ID of the new title
        /// </summary>
        [MessageProperty]
        public uint NewTitle { get; set; }        
        
        /// <summary>
        /// true if the title should be made the current title, false if it should just be added to the title list
        /// </summary>
        [MessageProperty]
        public bool SetAsDisplayTitle { get; set; }        
        


        public AddOrSetCharacterTitleS2C() : base((MessageType)0x002B, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AddOrSetCharacterTitleS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            NewTitle = reader.ReadUInt32();
            SetAsDisplayTitle = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(NewTitle);
            writer.WriteBool32(SetAsDisplayTitle);

        }


    }
}
