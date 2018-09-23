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
    /// HandleDefenderNotificationEvent: You have been hit by a creature's melee attack.
    /// </summary>
    public class HandleDefenderNotificationEventS2C : OrderedMessage
    {
        /// <summary>
        /// the name of the creature
        /// </summary>
        [MessageProperty]
        public string AttackersName { get; set; }        
        
        /// <summary>
        /// the type of damage done
        /// </summary>
        [MessageProperty]
        public DamageType Dtype { get; set; }        
        
        /// <summary>
        /// percentage of targets hp removed by damage. 0.0 (low) to 1.0 (high)
        /// </summary>
        [MessageProperty]
        public float Php { get; set; }        
        
        /// <summary>
        /// the amount of damage done
        /// </summary>
        [MessageProperty]
        public uint Hp { get; set; }        
        
        /// <summary>
        /// the location of the damage done
        /// </summary>
        [MessageProperty]
        public DamageLocation Part { get; set; }        
        
        /// <summary>
        /// critical hit: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public bool Critical { get; set; }        
        
        /// <summary>
        /// additional information about the attack, such as whether it was a Sneak Attack, etc.
        /// </summary>
        [MessageProperty]
        public AttackConditionsMask AttackConditions { get; set; }        
        


        public HandleDefenderNotificationEventS2C() : base((MessageType)0x01B2, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HandleDefenderNotificationEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            AttackersName = reader.ReadString16L();
            Dtype = (DamageType)reader.ReadUInt32();
            Php = reader.ReadSingle();
            Hp = reader.ReadUInt32();
            Part = (DamageLocation)reader.ReadUInt32();
            Critical = reader.ReadBool32();
            AttackConditions = (AttackConditionsMask)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(AttackersName);
            writer.Write((uint)Dtype);
            writer.Write(Php);
            writer.Write(Hp);
            writer.Write((uint)Part);
            writer.WriteBool32(Critical);
            writer.Write((uint)AttackConditions);

        }


    }
}
