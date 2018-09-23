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
    /// Set or update a Character Skill state
    /// </summary>
    public class UpdateSkillACS2C : Message
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
        /// skill ID
        /// </summary>
        [MessageProperty]
        public SkillID Key { get; set; }        
        
        /// <summary>
        /// skill state
        /// </summary>
        [MessageProperty]
        public SkillState Value { get; set; }        
        


        public UpdateSkillACS2C() : base((MessageType)0x02E2, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateSkillACS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Sequence = reader.ReadByte();
            ObjectID = reader.ReadUInt32();
            Key = (SkillID)reader.ReadUInt32();
            Value = (SkillState)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Sequence);
            writer.Write(ObjectID);
            writer.Write((uint)Key);
            writer.Write((uint)Value);

        }


    }
}
