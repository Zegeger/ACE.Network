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
    /// Set a single character option.
    /// </summary>
    public class PlayerOptionChangedEventC2S : OrderedMessage
    {
        /// <summary>
        /// the option being set
        /// </summary>
        [MessageProperty]
        public OptionPropertyID Po { get; set; }        
        
        /// <summary>
        /// the value of the option
        /// </summary>
        [MessageProperty]
        public bool Value { get; set; }        
        


        public PlayerOptionChangedEventC2S() : base((MessageType)0x0005, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public PlayerOptionChangedEventC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Po = (OptionPropertyID)reader.ReadInt32();
            Value = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((int)Po);
            writer.WriteBool32(Value);

        }


    }
}
