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
    /// Cast a spell with no target.
    /// </summary>
    public class CastUntargetedSpellC2S : OrderedMessage
    {
        /// <summary>
        /// The ID of the spell
        /// </summary>
        [MessageProperty]
        public LayeredSpellID SpellID { get; } = new LayeredSpellID();
        


        public CastUntargetedSpellC2S() : base((MessageType)0x0048, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public CastUntargetedSpellC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            SpellID.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            SpellID.Pack(writer);

        }


    }
}
