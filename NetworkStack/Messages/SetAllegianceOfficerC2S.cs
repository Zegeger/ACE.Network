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
    /// Sets an allegiance officer
    /// </summary>
    public class SetAllegianceOfficerC2S : OrderedMessage
    {
        /// <summary>
        /// The allegiance officer's name
        /// </summary>
        [MessageProperty]
        public string CharName { get; set; }        
        
        /// <summary>
        /// Level of the officer
        /// </summary>
        [MessageProperty]
        public AllegianceOfficerLevel Level { get; set; }        
        


        public SetAllegianceOfficerC2S() : base((MessageType)0x003B, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetAllegianceOfficerC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            CharName = reader.ReadString16L();
            Level = (AllegianceOfficerLevel)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(CharName);
            writer.Write((uint)Level);

        }


    }
}
