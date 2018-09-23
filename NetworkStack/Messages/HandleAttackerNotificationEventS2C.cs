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
    /// HandleAttackerNotificationEvent: You have hit your target with a melee attack.
    /// </summary>
    public class HandleAttackerNotificationEventS2C : OrderedMessage
    {
        /// <summary>
        /// the name of your target
        /// </summary>
        [MessageProperty]
        public string DefendersName { get; set; }        
        
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
        /// critical hit: 0=no, 1=yes
        /// </summary>
        [MessageProperty]
        public bool Critical { get; set; }        
        
        /// <summary>
        /// additional information about the attack, such as whether it was a Sneak Attack, etc
        /// </summary>
        [MessageProperty]
        public AttackConditionsMask AttackConditions { get; set; }        
        


        public HandleAttackerNotificationEventS2C() : base((MessageType)0x01B1, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public HandleAttackerNotificationEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            DefendersName = reader.ReadString16L();
            Dtype = (DamageType)reader.ReadUInt32();
            Php = reader.ReadSingle();
            Hp = reader.ReadUInt32();
            Critical = reader.ReadBool32();
            AttackConditions = (AttackConditionsMask)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteString16L(DefendersName);
            writer.Write((uint)Dtype);
            writer.Write(Php);
            writer.Write(Hp);
            writer.WriteBool32(Critical);
            writer.Write((uint)AttackConditions);

        }


    }
}
