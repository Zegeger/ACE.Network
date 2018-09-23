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
    /// Starts a missle attack against a target
    /// </summary>
    public class TargetedMissileAttackC2S : OrderedMessage
    {
        /// <summary>
        /// ID of creature being attacked
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        
        /// <summary>
        /// Height of the attack
        /// </summary>
        [MessageProperty]
        public AttackHeight AttackHeight { get; set; }        
        
        /// <summary>
        /// Accuracy level
        /// </summary>
        [MessageProperty]
        public float AccuracyLevel { get; set; }        
        


        public TargetedMissileAttackC2S() : base((MessageType)0x000A, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public TargetedMissileAttackC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Target = reader.ReadUInt32();
            AttackHeight = (AttackHeight)reader.ReadUInt32();
            AccuracyLevel = reader.ReadSingle();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Target);
            writer.Write((uint)AttackHeight);
            writer.Write(AccuracyLevel);

        }


    }
}
