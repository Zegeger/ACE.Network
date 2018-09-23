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
    /// Not found in client.  Based on previous data, related to opening of allegiance panel.
    /// </summary>
    public class AllegiancePanelOpenS2C : OrderedMessage
    {
        [MessageProperty]
        public uint Unknown { get; set; }        
        


        public AllegiancePanelOpenS2C() : base((MessageType)0x01C8, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AllegiancePanelOpenS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Unknown = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Unknown);

        }


    }
}
