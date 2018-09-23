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
    /// Applies an effect with visual and sound by providing the type to be looked up in the Physics Script Table
    /// </summary>
    public class PlayScriptTypeS2C : Message
    {
        /// <summary>
        /// ID of the object from which the effect originates. Can be you, another char/npc or an item.
        /// </summary>
        [MessageProperty]
        public uint ObjectID { get; set; }        
        
        /// <summary>
        /// The script type id
        /// </summary>
        [MessageProperty]
        public int ScriptType { get; set; }        
        
        /// <summary>
        /// Speed to play the particle effect at.  1.0 is default, lower for slower, higher for faster.
        /// </summary>
        [MessageProperty]
        public float Speed { get; set; }        
        


        public PlayScriptTypeS2C() : base((MessageType)0xF755, MessageDirection.ServerToClient, (Queues)0x0000000A)
        { }

        public PlayScriptTypeS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjectID = reader.ReadUInt32();
            ScriptType = reader.ReadInt32();
            Speed = reader.ReadSingle();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectID);
            writer.Write(ScriptType);
            writer.Write(Speed);

        }


    }
}
