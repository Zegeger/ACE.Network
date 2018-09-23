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
    /// Set or update an Object Boolean property value
    /// </summary>
    public class UpdateBoolS2C : Message
    {
        /// <summary>
        /// sequence number
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// object ID
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// Boolean property ID
        /// </summary>
        [MessageProperty]
        public BooleanPropertyID Key { get; set; }        
        
        /// <summary>
        /// Boolean property value (0=False, 1=True)
        /// </summary>
        [MessageProperty]
        public bool Value { get; set; }        
        


        public UpdateBoolS2C() : base((MessageType)0x02D2, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateBoolS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            ObjectID = reader.ReadUInt32();
            Key = (BooleanPropertyID)reader.ReadUInt32();
            Value = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write(ObjectID);
            writer.Write((uint)Key);
            writer.WriteBool32(Value);

        }


    }
}
