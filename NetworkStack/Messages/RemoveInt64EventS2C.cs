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
    /// Private Remove Int Event
    /// </summary>
    public class RemoveInt64EventS2C : Message
    {
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// sender ID
        /// </summary>
        [MessageProperty]
        public uint Sender { get; set; }        
        
        [MessageProperty]
        public Int64PropertyID Type { get; set; }        
        


        public RemoveInt64EventS2C() : base((MessageType)0x02B9, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public RemoveInt64EventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Sender = reader.ReadUInt32();
            Type = (Int64PropertyID)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write(Sender);
            writer.Write((uint)Type);

        }


    }
}
