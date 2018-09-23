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
    /// Spend skill credits to train a skill.
    /// </summary>
    public class TrainSkillAdvancementClassC2S : OrderedMessage
    {
        /// <summary>
        /// The ID of the skill
        /// </summary>
        [MessageProperty]
        public SkillID Stype { get; set; }        
        
        /// <summary>
        /// The number of skill credits being spent
        /// </summary>
        [MessageProperty]
        public uint CreditsSpent { get; set; }        
        


        public TrainSkillAdvancementClassC2S() : base((MessageType)0x0047, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public TrainSkillAdvancementClassC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Stype = (SkillID)reader.ReadUInt32();
            CreditsSpent = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Stype);
            writer.Write(CreditsSpent);

        }


    }
}
