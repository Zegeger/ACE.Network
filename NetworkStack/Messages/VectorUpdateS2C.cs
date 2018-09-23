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
    /// Changes an objects vector, for things like jumping
    /// </summary>
    public class VectorUpdateS2C : Message
    {
        /// <summary>
        /// ID of the object being updated
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// new velocity component
        /// </summary>
        [MessageProperty]
        public Vector3 Velocity { get; } = new Vector3();
        
        /// <summary>
        /// new omega component
        /// </summary>
        [MessageProperty]
        public Vector3 Omega { get; } = new Vector3();
        
        /// <summary>
        /// The instance sequence value for this object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        
        /// <summary>
        /// The vector sequence value for this object
        /// </summary>
        [MessageProperty]
        public ushort ObjectVectorSequence { get; set; }        
        


        public VectorUpdateS2C() : base((MessageType)0xF74E, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public VectorUpdateS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            Velocity.Unpack(reader);
            Omega.Unpack(reader);
            ObjectInstanceSequence = reader.ReadUInt16();
            ObjectVectorSequence = reader.ReadUInt16();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            Velocity.Pack(writer);
            Omega.Pack(writer);
            writer.Write(ObjectInstanceSequence);
            writer.Write(ObjectVectorSequence);

        }


    }
}
