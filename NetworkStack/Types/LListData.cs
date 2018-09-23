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
    /// Command data
    /// </summary>
    public class LListData : IPackable
    {
        /// <summary>
        /// Command ID
        /// </summary>
        [MessageProperty]
        public Command CommandID { get; set; }        
        
        /// <summary>
        /// Sequence of the animation.
        /// </summary>
        [MessageProperty]
        public ushort ServerActionSequence { get; set; }        
        
        
        /// <summary>
        /// Whether command is autonomous
        /// </summary>
        [MessageProperty]
        public ushort Autonomous { get; set; }        
        
        
        /// <summary>
        /// Command speed
        /// </summary>
        [MessageProperty]
        public float Speed { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            CommandID = (Command)reader.ReadUInt16();
            ushort PackedSequence = reader.ReadUInt16();
            ServerActionSequence = (ushort)(PackedSequence & 0x7FFF);
            Autonomous = (ushort)(PackedSequence >> 15 & 0x1);
            Speed = reader.ReadSingle();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((ushort)CommandID);
            ushort PackedSequence = 0;
            PackedSequence |= (ushort)(ServerActionSequence & 0x7FFF);
            PackedSequence |= (ushort)(Autonomous & 0x1 << 15);
            writer.Write(PackedSequence);
            writer.Write(Speed);

        }


    }
}
