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
    /// Private Remove IID Event
    /// </summary>
    public class PrivateRemoveInstanceIDEventS2C : Message
    {
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        [MessageProperty]
        public InstancePropertyID Type { get; set; }        
        


        public PrivateRemoveInstanceIDEventS2C() : base((MessageType)0x01DB, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public PrivateRemoveInstanceIDEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Type = (InstancePropertyID)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write((uint)Type);

        }


    }
}
