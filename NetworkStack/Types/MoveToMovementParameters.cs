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
    /// Set of movement parameters required for a MoveTo movement
    /// </summary>
    public class MoveToMovementParameters : IPackable
    {
        /// <summary>
        /// bitmember of some options related to the motion (TODO needs further research)
        /// </summary>
        [MessageProperty]
        public uint Bitmember { get; set; }        
        
        /// <summary>
        /// The distance to the given location
        /// </summary>
        [MessageProperty]
        public float DistanceToObject { get; set; }        
        
        /// <summary>
        /// The minimum distance required for the movement
        /// </summary>
        [MessageProperty]
        public float MinDistance { get; set; }        
        
        /// <summary>
        /// The distance at which the movement will fail
        /// </summary>
        [MessageProperty]
        public float FailDistance { get; set; }        
        
        /// <summary>
        /// speed of animation
        /// </summary>
        [MessageProperty]
        public float AnimationSpeed { get; set; }        
        
        /// <summary>
        /// The distance from the location which determines whether you walk or run towards it.
        /// </summary>
        [MessageProperty]
        public float WalkRunThreshold { get; set; }        
        
        /// <summary>
        /// Heading the object is turning to
        /// </summary>
        [MessageProperty]
        public float DesiredHeading { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Bitmember = reader.ReadUInt32();
            DistanceToObject = reader.ReadSingle();
            MinDistance = reader.ReadSingle();
            FailDistance = reader.ReadSingle();
            AnimationSpeed = reader.ReadSingle();
            WalkRunThreshold = reader.ReadSingle();
            DesiredHeading = reader.ReadSingle();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Bitmember);
            writer.Write(DistanceToObject);
            writer.Write(MinDistance);
            writer.Write(FailDistance);
            writer.Write(AnimationSpeed);
            writer.Write(WalkRunThreshold);
            writer.Write(DesiredHeading);

        }


    }
}
