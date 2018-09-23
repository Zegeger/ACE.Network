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
    /// A the location and orientation of an object within a landcell
    /// </summary>
    public class Frame : IPackable
    {
        /// <summary>
        /// the location in a landcell in which the object is located
        /// </summary>
        [MessageProperty]
        public Vector3 Origin { get; } = new Vector3();
        
        /// <summary>
        /// a quaternion describing the object's orientation
        /// </summary>
        [MessageProperty]
        public Quaternion Orientation { get; } = new Quaternion();
        


        public void Unpack(BinaryReader reader)
        {
            Origin.Unpack(reader);
            Orientation.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Origin.Pack(writer);
            Orientation.Pack(writer);

        }


    }
}
