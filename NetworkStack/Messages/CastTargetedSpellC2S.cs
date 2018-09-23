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
    /// Cast a spell on a target
    /// </summary>
    public class CastTargetedSpellC2S : OrderedMessage
    {
        /// <summary>
        /// The target of the spell
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        
        /// <summary>
        /// The ID of the spell
        /// </summary>
        [MessageProperty]
        public LayeredSpellID SpellID { get; } = new LayeredSpellID();
        


        public CastTargetedSpellC2S() : base((MessageType)0x004A, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public CastTargetedSpellC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadUInt32();
            SpellID.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Target);
            SpellID.Pack(writer);

        }


    }
}
