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
    /// Update Restrictions
    /// </summary>
    public class UpdateRestrictionsS2C : OrderedMessage
    {
        /// <summary>
        /// Sequence value for restrictions list for this house
        /// </summary>
        [MessageProperty]
        public byte Sequence { get; set; }        
        
        /// <summary>
        /// Object having restrictions updated
        /// </summary>
        [MessageProperty]
        public uint Sender { get; set; }        
        
        /// <summary>
        /// Restrictions database
        /// </summary>
        [MessageProperty]
        public RestrictionDB Db { get; } = new RestrictionDB();
        


        public UpdateRestrictionsS2C() : base((MessageType)0x0248, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateRestrictionsS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            Sender = reader.ReadUInt32();
            Db.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write(Sender);
            Db.Pack(writer);

        }


    }
}
