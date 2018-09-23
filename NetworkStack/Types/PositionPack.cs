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
    /// A position with sequences
    /// </summary>
    public class PositionPack : IPackable
    {
        [MessageProperty]
        public PositionFlags Flags { get; set; }        
        
        /// <summary>
        /// the location of the object in the world
        /// </summary>
        [MessageProperty]
        public Origin Origin { get; } = new Origin();
        
        [MessageProperty]
        public float WQuat { get; set; }        
        
        [MessageProperty]
        public float XQuat { get; set; }        
        
        [MessageProperty]
        public float YQuat { get; set; }        
        
        [MessageProperty]
        public float ZQuat { get; set; }        
        
        [MessageProperty]
        public Vector3 Velocity { get; } = new Vector3();
        
        [MessageProperty]
        public uint PlacementID { get; set; }        
        
        /// <summary>
        /// The instance sequence value for the object (number of logins for players)
        /// </summary>
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        
        /// <summary>
        /// The position sequence value for the object
        /// </summary>
        [MessageProperty]
        public ushort ObjectPositionSequence { get; set; }        
        
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
            Flags = (PositionFlags)reader.ReadUInt32();
            Origin.Unpack(reader);
            if((Flags & PositionFlags.OrientationHasNoW) == 0)
            {
                WQuat = reader.ReadSingle();
            }
            if((Flags & PositionFlags.OrientationHasNoX) == 0)
            {
                XQuat = reader.ReadSingle();
            }
            if((Flags & PositionFlags.OrientationHasNoY) == 0)
            {
                YQuat = reader.ReadSingle();
            }
            if((Flags & PositionFlags.OrientationHasNoZ) == 0)
            {
                ZQuat = reader.ReadSingle();
            }
            if((Flags & PositionFlags.HasVelocity) != 0)
            {
                Velocity.Unpack(reader);
            }
            if((Flags & PositionFlags.HasPlacementID) != 0)
            {
                PlacementID = reader.ReadUInt32();
            }
            ObjectInstanceSequence = reader.ReadUInt16();
            ObjectPositionSequence = reader.ReadUInt16();
            ObjectTeleportSequence = reader.ReadUInt16();
            ObjectForcePositionSequence = reader.ReadUInt16();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Flags);
            Origin.Pack(writer);
            if((Flags & PositionFlags.OrientationHasNoW) == 0)
            {
                writer.Write(WQuat);
            }
            if((Flags & PositionFlags.OrientationHasNoX) == 0)
            {
                writer.Write(XQuat);
            }
            if((Flags & PositionFlags.OrientationHasNoY) == 0)
            {
                writer.Write(YQuat);
            }
            if((Flags & PositionFlags.OrientationHasNoZ) == 0)
            {
                writer.Write(ZQuat);
            }
            if((Flags & PositionFlags.HasVelocity) != 0)
            {
                Velocity.Pack(writer);
            }
            if((Flags & PositionFlags.HasPlacementID) != 0)
            {
                writer.Write(PlacementID);
            }
            writer.Write(ObjectInstanceSequence);
            writer.Write(ObjectPositionSequence);
            writer.Write(ObjectTeleportSequence);
            writer.Write(ObjectForcePositionSequence);

        }


    }
}
