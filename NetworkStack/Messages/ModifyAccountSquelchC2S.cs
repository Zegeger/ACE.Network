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
    /// Changes an account squelch
    /// </summary>
    public class ModifyAccountSquelchC2S : OrderedMessage
    {
        /// <summary>
        /// 0 = unsquelch, 1 = squelch
        /// </summary>
        [MessageProperty]
        public bool Add { get; set; }        
        
        /// <summary>
        /// The character who's acount should be squelched
        /// </summary>
        [MessageProperty]
        public string CharacterName { get; set; }        
        


        public ModifyAccountSquelchC2S() : base((MessageType)0x0059, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ModifyAccountSquelchC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Add = reader.ReadBool32();
            CharacterName = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(Add);
            writer.WriteString16L(CharacterName);

        }


    }
}
