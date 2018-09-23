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
    /// QueryHealthResponse: Update a creature's health bar.
    /// </summary>
    public class QueryHealthResponseS2C : OrderedMessage
    {
        /// <summary>
        /// the object ID of the creature
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        
        /// <summary>
        /// the amount of health remaining, scaled from 0.0 (none) to 1.0 (full)
        /// </summary>
        [MessageProperty]
        public float Health { get; set; }        
        


        public QueryHealthResponseS2C() : base((MessageType)0x01C0, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public QueryHealthResponseS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadUInt32();
            Health = reader.ReadSingle();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Target);
            writer.Write(Health);

        }


    }
}
