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
    /// Create an object somewhere in the world
    /// </summary>
    public class CreateObjectS2C : Message
    {
        /// <summary>
        /// object ID
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        [MessageProperty]
        public ObjDesc ObjDesc { get; } = new ObjDesc();
        
        [MessageProperty]
        public PhysicsDesc Physicsdesc { get; } = new PhysicsDesc();
        
        [MessageProperty]
        public PublicWeenieDesc Wdesc { get; } = new PublicWeenieDesc();
        


        public CreateObjectS2C() : base((MessageType)0xF745, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public CreateObjectS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            ObjDesc.Unpack(reader);
            Physicsdesc.Unpack(reader);
            Wdesc.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            ObjDesc.Pack(writer);
            Physicsdesc.Pack(writer);
            Wdesc.Pack(writer);

        }


    }
}
