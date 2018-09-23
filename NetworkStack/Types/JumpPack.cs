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
    /// A jump with sequences
    /// </summary>
    public class JumpPack : IPackable
    {
        /// <summary>
        /// Power of jump?
        /// </summary>
        [MessageProperty]
        public float Extent { get; set; }        
        
        /// <summary>
        /// Velocity data
        /// </summary>
        [MessageProperty]
        public Vector3 Velocity { get; } = new Vector3();
        
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
        


        public void Unpack(BinaryReader reader)
        {
            Extent = reader.ReadSingle();
            Velocity.Unpack(reader);
            ObjectInstanceSequence = reader.ReadUInt16();
            ObjectServerControlSequence = reader.ReadUInt16();
            ObjectTeleportSequence = reader.ReadUInt16();
            ObjectForcePositionSequence = reader.ReadUInt16();
            reader.Align();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Extent);
            Velocity.Pack(writer);
            writer.Write(ObjectInstanceSequence);
            writer.Write(ObjectServerControlSequence);
            writer.Write(ObjectTeleportSequence);
            writer.Write(ObjectForcePositionSequence);
            writer.Align();

        }


    }
}
