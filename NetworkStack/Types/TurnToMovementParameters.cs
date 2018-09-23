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
    /// Set of movement parameters required for a TurnTo motion
    /// </summary>
    public class TurnToMovementParameters : IPackable
    {
        /// <summary>
        /// bitmember of some options related to the motion (TODO needs further research)
        /// </summary>
        [MessageProperty]
        public uint Bitmember { get; set; }        
        
        /// <summary>
        /// speed of animation
        /// </summary>
        [MessageProperty]
        public float AnimationSpeed { get; set; }        
        
        /// <summary>
        /// Heading the object is turning to
        /// </summary>
        [MessageProperty]
        public float DesiredHeading { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Bitmember = reader.ReadUInt32();
            AnimationSpeed = reader.ReadSingle();
            DesiredHeading = reader.ReadSingle();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Bitmember);
            writer.Write(AnimationSpeed);
            writer.Write(DesiredHeading);

        }


    }
}
