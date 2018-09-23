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
    /// Sets a person as an approved vassal
    /// </summary>
    public class SetAllegianceApprovedVassalC2S : OrderedMessage
    {
        /// <summary>
        /// Player who is being approved as a vassal
        /// </summary>
        [MessageProperty]
        public string CharName { get; set; }        
        


        public SetAllegianceApprovedVassalC2S() : base((MessageType)0x0040, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public SetAllegianceApprovedVassalC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            CharName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(CharName);

        }


    }
}
