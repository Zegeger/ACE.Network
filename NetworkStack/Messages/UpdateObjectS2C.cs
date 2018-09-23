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
    /// Update an existing object's data.
    /// </summary>
    public class UpdateObjectS2C : Message
    {
        /// <summary>
        /// the object being updated
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// updated model data
        /// </summary>
        [MessageProperty]
        public ObjDesc ObjDesc { get; } = new ObjDesc();
        
        /// <summary>
        /// updated physics data
        /// </summary>
        [MessageProperty]
        public PhysicsDesc PhysicsDesc { get; } = new PhysicsDesc();
        
        /// <summary>
        /// updated game data
        /// </summary>
        [MessageProperty]
        public PublicWeenieDesc Wdesc { get; } = new PublicWeenieDesc();
        


        public UpdateObjectS2C() : base((MessageType)0xF7DB, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public UpdateObjectS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            ObjDesc.Unpack(reader);
            PhysicsDesc.Unpack(reader);
            Wdesc.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            ObjDesc.Pack(writer);
            PhysicsDesc.Pack(writer);
            Wdesc.Pack(writer);

        }


    }
}
