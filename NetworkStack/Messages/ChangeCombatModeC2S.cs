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
    /// Changes the combat mode
    /// </summary>
    public class ChangeCombatModeC2S : OrderedMessage
    {
        /// <summary>
        /// New combat mode for player
        /// </summary>
        [MessageProperty]
        public CombatMode Mode { get; set; }        
        


        public ChangeCombatModeC2S() : base((MessageType)0x0053, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ChangeCombatModeC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Mode = (CombatMode)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Mode);

        }


    }
}
