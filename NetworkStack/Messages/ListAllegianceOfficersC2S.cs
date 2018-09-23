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
    /// List allegiance officers
    /// </summary>
    public class ListAllegianceOfficersC2S : OrderedMessage
    {


        public ListAllegianceOfficersC2S() : base((MessageType)0x02A6, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ListAllegianceOfficersC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {

        }


    }
}
