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
    /// Removes an allegiance officer
    /// </summary>
    public class RemoveAllegianceOfficerC2S : OrderedMessage
    {
        /// <summary>
        /// Character name being removed
        /// </summary>
        [MessageProperty]
        public string CharName { get; set; }        
        


        public RemoveAllegianceOfficerC2S() : base((MessageType)0x02A5, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public RemoveAllegianceOfficerC2S(BinaryReader reader) : this()
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
