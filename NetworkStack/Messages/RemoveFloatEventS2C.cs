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
    /// Remove Float Event
    /// </summary>
    public class RemoveFloatEventS2C : Message
    {
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        [MessageProperty]
        public uint Sender { get; set; }        
        
        [MessageProperty]
        public FloatPropertyID Type { get; set; }        
        


        public RemoveFloatEventS2C() : base((MessageType)0x01D6, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public RemoveFloatEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Sender = reader.ReadUInt32();
            Type = (FloatPropertyID)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write(Sender);
            writer.Write((uint)Type);

        }


    }
}
