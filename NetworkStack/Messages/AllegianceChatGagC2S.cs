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
    /// Gags a person in allegiance chat
    /// </summary>
    public class AllegianceChatGagC2S : OrderedMessage
    {
        /// <summary>
        /// Player who is being gagged or ungagged
        /// </summary>
        [MessageProperty]
        public string CharName { get; set; }        
        
        /// <summary>
        /// Whether the gag is on
        /// </summary>
        [MessageProperty]
        public bool On { get; set; }        
        


        public AllegianceChatGagC2S() : base((MessageType)0x0041, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AllegianceChatGagC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            CharName = reader.ReadString16L();
            On = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(CharName);
            writer.WriteBool32(On);

        }


    }
}
