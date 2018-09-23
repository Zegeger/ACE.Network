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
    /// Returns info related to your monarch, patron and vassals.
    /// </summary>
    public class AllegianceUpdateS2C : OrderedMessage
    {
        [MessageProperty]
        public uint Rank { get; set; }        
        
        [MessageProperty]
        public AllegianceProfile Prof { get; } = new AllegianceProfile();
        


        public AllegianceUpdateS2C() : base((MessageType)0x0020, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AllegianceUpdateS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Rank = reader.ReadUInt32();
            Prof.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Rank);
            Prof.Pack(writer);

        }


    }
}
