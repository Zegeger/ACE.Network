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
    /// The PhysicsDesc structure defines an object's physical behavior.
    /// </summary>
    public class PhysicsDesc : IPackable
    {
        /// <summary>
        /// physics data flags
        /// </summary>
        [MessageProperty]
        public uint Flags { get; set; }        
        
        /// <summary>
        /// The current physics state for the object
        /// </summary>
        [MessageProperty]
        public PhysicsState State { get; set; }        
        
        /// <summary>
        /// the number of BYTEs in the following movement buffer
        /// </summary>
        [MessageProperty]
        public uint MovementByteCount { get; set; }        
        
        /// <summary>
        /// The movement buffer for this object defining its initial movement state
        /// </summary>
        [MessageProperty]
        public byte[] Bytes { get; set; }        
        
        /// <summary>
        /// Whether the movement is autonomous (0 for no, 1 for yes).  NOTE that this is only present if movementByteCount > 0
        /// </summary>
        [MessageProperty]
        public bool Autonomous { get; set; }        
        
        /// <summary>
        /// The current animation frame.  NOTE this can only be present if 0x00010000 is not set
        /// </summary>
        [MessageProperty]
        public uint AnimationFrame { get; set; }        
        
        /// <summary>
        /// object position
        /// </summary>
        [MessageProperty]
        public Position Position { get; } = new Position();
        
        /// <summary>
        /// motion table id for this object
        /// </summary>
        [MessageProperty]
        public uint MotionTableID { get; set; }        
        
        /// <summary>
        /// sound table id for this object
        /// </summary>
        [MessageProperty]
        public uint SoundTableID { get; set; }        
        
        /// <summary>
        /// physics script table id for this object
        /// </summary>
        [MessageProperty]
        public uint PhysicsScriptTableID { get; set; }        
        
        /// <summary>
        /// setup table id for this object
        /// </summary>
        [MessageProperty]
        public uint SetupTableID { get; set; }        
        
        /// <summary>
        /// the creature equipping this object
        /// </summary>
        [MessageProperty]
        public uint Parent { get; set; }        
        
        /// <summary>
        /// the slot in which this object is equipped, referenced in the Setup table of the dats
        /// </summary>
        [MessageProperty]
        public uint LocationID { get; set; }        
        
        /// <summary>
        /// the number of items equipped by this creature
        /// </summary>
        [MessageProperty]
        public uint NumChildren { get; set; }        
        
        [MessageProperty]
        public List<ChildInfo> Children { get; } = new List<ChildInfo>();
        
        /// <summary>
        /// the size of this object
        /// </summary>
        [MessageProperty]
        public float Scale { get; set; }        
        
        [MessageProperty]
        public float Friction { get; set; }        
        
        [MessageProperty]
        public float Elasticity { get; set; }        
        
        [MessageProperty]
        public float Translucency { get; set; }        
        
        /// <summary>
        /// velocity vector x component
        /// </summary>
        [MessageProperty]
        public float VelocityX { get; set; }        
        
        /// <summary>
        /// velocity vector y component
        /// </summary>
        [MessageProperty]
        public float VelocityY { get; set; }        
        
        /// <summary>
        /// velocity vector z component
        /// </summary>
        [MessageProperty]
        public float VelocityZ { get; set; }        
        
        /// <summary>
        /// acceleration vector x component
        /// </summary>
        [MessageProperty]
        public float AccelerationX { get; set; }        
        
        /// <summary>
        /// acceleration vector y component
        /// </summary>
        [MessageProperty]
        public float AccelerationY { get; set; }        
        
        /// <summary>
        /// acceleration vector z component
        /// </summary>
        [MessageProperty]
        public float AccelerationZ { get; set; }        
        
        /// <summary>
        /// omega vector x component (rotation)
        /// </summary>
        [MessageProperty]
        public float OmegaX { get; set; }        
        
        /// <summary>
        /// omega vector y component (rotation)
        /// </summary>
        [MessageProperty]
        public float OmegaY { get; set; }        
        
        /// <summary>
        /// omega vector z component (rotation)
        /// </summary>
        [MessageProperty]
        public float OmegaZ { get; set; }        
        
        [MessageProperty]
        public uint DefaultScript { get; set; }        
        
        [MessageProperty]
        public float DefaultScriptIntensity { get; set; }        
        
        [MessageProperty]
        public ushort ObjectPositionSequence { get; set; }        
        
        [MessageProperty]
        public ushort ObjectMovementSequence { get; set; }        
        
        [MessageProperty]
        public ushort ObjectStateSequence { get; set; }        
        
        [MessageProperty]
        public ushort ObjectVectorSequence { get; set; }        
        
        [MessageProperty]
        public ushort ObjectTeleportSequence { get; set; }        
        
        [MessageProperty]
        public ushort ObjectServerControlSequence { get; set; }        
        
        [MessageProperty]
        public ushort ObjectForcePositionSequence { get; set; }        
        
        [MessageProperty]
        public ushort ObjectVisualDescSequence { get; set; }        
        
        [MessageProperty]
        public ushort ObjectInstanceSequence { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Flags = reader.ReadUInt32();
            State = (PhysicsState)reader.ReadUInt32();
            if((Flags & 0x00010000) != 0)
            {
                MovementByteCount = reader.ReadUInt32();
                if(MovementByteCount > 0)
                {
                    Bytes = new byte[MovementByteCount];
                    for(int i = 0; i < MovementByteCount; i++)
                    {
                        Bytes[i] = reader.ReadByte();
                    }
                    Autonomous = reader.ReadBool32();
                }
            }
            if((Flags & 0x00020000) != 0)
            {
                AnimationFrame = reader.ReadUInt32();
            }
            if((Flags & 0x00008000) != 0)
            {
                Position.Unpack(reader);
            }
            if((Flags & 0x00000002) != 0)
            {
                MotionTableID = reader.ReadUInt32();
            }
            if((Flags & 0x00000800) != 0)
            {
                SoundTableID = reader.ReadUInt32();
            }
            if((Flags & 0x00001000) != 0)
            {
                PhysicsScriptTableID = reader.ReadUInt32();
            }
            if((Flags & 0x00000001) != 0)
            {
                SetupTableID = reader.ReadUInt32();
            }
            if((Flags & 0x00000020) != 0)
            {
                Parent = reader.ReadUInt32();
                LocationID = reader.ReadUInt32();
            }
            if((Flags & 0x00000040) != 0)
            {
                NumChildren = reader.ReadUInt32();
                Children.Clear();
                for(int i = 0; i < NumChildren; i++)
                {
                    ChildInfo newItem = new ChildInfo();
                    newItem.Unpack(reader);
                    Children.Add(newItem);
                }
            }
            if((Flags & 0x00000080) != 0)
            {
                Scale = reader.ReadSingle();
            }
            if((Flags & 0x00000100) != 0)
            {
                Friction = reader.ReadSingle();
            }
            if((Flags & 0x00000200) != 0)
            {
                Elasticity = reader.ReadSingle();
            }
            if((Flags & 0x00040000) != 0)
            {
                Translucency = reader.ReadSingle();
            }
            if((Flags & 0x00000004) != 0)
            {
                VelocityX = reader.ReadSingle();
                VelocityY = reader.ReadSingle();
                VelocityZ = reader.ReadSingle();
            }
            if((Flags & 0x00000008) != 0)
            {
                AccelerationX = reader.ReadSingle();
                AccelerationY = reader.ReadSingle();
                AccelerationZ = reader.ReadSingle();
            }
            if((Flags & 0x00000010) != 0)
            {
                OmegaX = reader.ReadSingle();
                OmegaY = reader.ReadSingle();
                OmegaZ = reader.ReadSingle();
            }
            if((Flags & 0x00002000) != 0)
            {
                DefaultScript = reader.ReadUInt32();
            }
            if((Flags & 0x00004000) != 0)
            {
                DefaultScriptIntensity = reader.ReadSingle();
            }
            ObjectPositionSequence = reader.ReadUInt16();
            ObjectMovementSequence = reader.ReadUInt16();
            ObjectStateSequence = reader.ReadUInt16();
            ObjectVectorSequence = reader.ReadUInt16();
            ObjectTeleportSequence = reader.ReadUInt16();
            ObjectServerControlSequence = reader.ReadUInt16();
            ObjectForcePositionSequence = reader.ReadUInt16();
            ObjectVisualDescSequence = reader.ReadUInt16();
            ObjectInstanceSequence = reader.ReadUInt16();
            reader.Align();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Flags);
            writer.Write((uint)State);
            if((Flags & 0x00010000) != 0)
            {
                writer.Write(MovementByteCount);
                if(MovementByteCount > 0)
                {
                    for(int i = 0; i < MovementByteCount; i++)
                    {
                        writer.Write(Bytes);
                    }
                    writer.WriteBool32(Autonomous);
                }
            }
            if((Flags & 0x00020000) != 0)
            {
                writer.Write(AnimationFrame);
            }
            if((Flags & 0x00008000) != 0)
            {
                Position.Pack(writer);
            }
            if((Flags & 0x00000002) != 0)
            {
                writer.Write(MotionTableID);
            }
            if((Flags & 0x00000800) != 0)
            {
                writer.Write(SoundTableID);
            }
            if((Flags & 0x00001000) != 0)
            {
                writer.Write(PhysicsScriptTableID);
            }
            if((Flags & 0x00000001) != 0)
            {
                writer.Write(SetupTableID);
            }
            if((Flags & 0x00000020) != 0)
            {
                writer.Write(Parent);
                writer.Write(LocationID);
            }
            if((Flags & 0x00000040) != 0)
            {
                writer.Write(NumChildren);
                for(int i = 0; i < NumChildren; i++)
                {
                    Children[i].Pack(writer);
                }
            }
            if((Flags & 0x00000080) != 0)
            {
                writer.Write(Scale);
            }
            if((Flags & 0x00000100) != 0)
            {
                writer.Write(Friction);
            }
            if((Flags & 0x00000200) != 0)
            {
                writer.Write(Elasticity);
            }
            if((Flags & 0x00040000) != 0)
            {
                writer.Write(Translucency);
            }
            if((Flags & 0x00000004) != 0)
            {
                writer.Write(VelocityX);
                writer.Write(VelocityY);
                writer.Write(VelocityZ);
            }
            if((Flags & 0x00000008) != 0)
            {
                writer.Write(AccelerationX);
                writer.Write(AccelerationY);
                writer.Write(AccelerationZ);
            }
            if((Flags & 0x00000010) != 0)
            {
                writer.Write(OmegaX);
                writer.Write(OmegaY);
                writer.Write(OmegaZ);
            }
            if((Flags & 0x00002000) != 0)
            {
                writer.Write(DefaultScript);
            }
            if((Flags & 0x00004000) != 0)
            {
                writer.Write(DefaultScriptIntensity);
            }
            writer.Write(ObjectPositionSequence);
            writer.Write(ObjectMovementSequence);
            writer.Write(ObjectStateSequence);
            writer.Write(ObjectVectorSequence);
            writer.Write(ObjectTeleportSequence);
            writer.Write(ObjectServerControlSequence);
            writer.Write(ObjectForcePositionSequence);
            writer.Write(ObjectVisualDescSequence);
            writer.Write(ObjectInstanceSequence);
            writer.Align();

        }


    }
}
