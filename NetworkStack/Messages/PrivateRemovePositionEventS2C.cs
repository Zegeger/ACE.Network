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
    /// Private Remove Position Event
    /// </summary>
    public class PrivateRemovePositionEventS2C : Message
    {
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        [MessageProperty]
        public PositionPropertyID Type { get; set; }        
        


        public PrivateRemovePositionEventS2C() : base((MessageType)0x01DD, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PrivateRemovePositionEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Type = (PositionPropertyID)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write((uint)Type);

        }


    }
}
