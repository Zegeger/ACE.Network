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
    /// Applies a sound effect.
    /// </summary>
    public class SoundEventS2C : Message
    {
        /// <summary>
        /// ID of the object from which the effect originates. Can be you, another char/npc or an item.
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The sound type ID, which is referenced in the Sound Table.
        /// </summary>
        [MessageProperty]
        public int SoundType { get; set; }        
        
        /// <summary>
        /// Volume to play the sound
        /// </summary>
        [MessageProperty]
        public float Volume { get; set; }        
        


        public SoundEventS2C() : base((MessageType)0xF750, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public SoundEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            SoundType = reader.ReadInt32();
            Volume = reader.ReadSingle();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(SoundType);
            writer.Write(Volume);

        }


    }
}
