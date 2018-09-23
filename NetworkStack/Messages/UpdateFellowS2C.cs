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
    /// Add/Update a member to your fellowship.
    /// </summary>
    public class UpdateFellowS2C : OrderedMessage
    {
        [MessageProperty]
        public Fellow Fellow { get; } = new Fellow();
        
        [MessageProperty]
        public FellowUpdateType UpdateType { get; set; }        
        


        public UpdateFellowS2C() : base((MessageType)0x02C0, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateFellowS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Fellow.Unpack(reader);
            UpdateType = (FellowUpdateType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            Fellow.Pack(writer);
            writer.Write((uint)UpdateType);

        }


    }
}
