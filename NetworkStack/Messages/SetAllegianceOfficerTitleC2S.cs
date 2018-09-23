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
    /// Sets an allegiance officer title for a given level
    /// </summary>
    public class SetAllegianceOfficerTitleC2S : OrderedMessage
    {
        /// <summary>
        /// The allegiance officer level
        /// </summary>
        [MessageProperty]
        public AllegianceOfficerLevel Level { get; set; }        
        
        /// <summary>
        /// The new title for officers at that level
        /// </summary>
        [MessageProperty]
        public string Title { get; set; }        
        


        public SetAllegianceOfficerTitleC2S() : base((MessageType)0x003C, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetAllegianceOfficerTitleC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Level = (AllegianceOfficerLevel)reader.ReadUInt32();
            Title = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Level);
            writer.WriteString16L(Title);

        }


    }
}
