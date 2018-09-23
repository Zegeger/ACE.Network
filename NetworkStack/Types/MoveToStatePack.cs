////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// A set of data related to changing states with sequences
    /// </summary>
    public class MoveToStatePack : IPackable
    {
        /// <summary>
        /// Raw motion data
        /// </summary>
        [MessageProperty]
        public RawMotionState RawMotionState { get; } = new RawMotionState();
        
        /// <summary>
        /// Position data
        /// </summary>
        [MessageProperty]
        public Position Position { get; } = new Position();
        
        /// <summary>
        /// The instance sequence value for the object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        
        /// <summary>
        /// The server control sequence value for the object
        /// </summary>
        [MessageProperty]
        public ushort ObjectServerControlSequence { get; set; }        
        
        /// <summary>
        /// The teleport sequence value for the object
        /// </summary>
        [MessageProperty]
        public ushort ObjectTeleportSequence { get; set; }        
        
        /// <summary>
        /// The forced position sequence value for the object
        /// </summary>
        [MessageProperty]
        public ushort ObjectForcePositionSequence { get; set; }        
        
        /// <summary>
        /// Whether the player has contact with the ground, or if we are in longjump_mode(1 = contact, 2 = longjump_mode)
        /// </summary>
        [MessageProperty]
        public byte Contact { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            RawMotionState.Unpack(reader);
            Position.Unpack(reader);
            ObjectInstanceSequence = reader.ReadUInt16();
            ObjectServerControlSequence = reader.ReadUInt16();
            ObjectTeleportSequence = reader.ReadUInt16();
            ObjectForcePositionSequence = reader.ReadUInt16();
            Contact = reader.ReadByte();
            reader.Align();

        }

        public void Pack(BinaryWriter writer)
        {
            RawMotionState.Pack(writer);
            Position.Pack(writer);
            writer.Write(ObjectInstanceSequence);
            writer.Write(ObjectServerControlSequence);
            writer.Write(ObjectTeleportSequence);
            writer.Write(ObjectForcePositionSequence);
            writer.Write(Contact);
            writer.Align();

        }


    }
}
