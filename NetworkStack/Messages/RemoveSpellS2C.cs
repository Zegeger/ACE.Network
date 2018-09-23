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
    /// RemoveSpell: Delete a spell from your spellbook.
    /// </summary>
    public class RemoveSpellS2C : OrderedMessage
    {
        [MessageProperty]
        public LayeredSpellID SpellID { get; } = new LayeredSpellID();
        


        public RemoveSpellS2C() : base((MessageType)0x01A8, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public RemoveSpellS2C(BinaryReader reader) : this()
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
