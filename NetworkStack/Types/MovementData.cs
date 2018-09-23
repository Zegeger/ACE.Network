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
    /// Data related to the movement and animation of the object
    /// </summary>
    public class MovementData : IPackable
    {
        /// <summary>
        /// The movement sequence value for this object
        /// </summary>
        [MessageProperty]
        public ushort ObjectMovementSequence { get; set; }        
        
        /// <summary>
        /// The server control sequence value for the object
        /// </summary>
        [MessageProperty]
        public ushort ObjectServerControlSequence { get; set; }        
        
        /// <summary>
        /// 0x0 - server controlled, 0x1 - autonomous
        /// </summary>
        [MessageProperty]
        public ushort Autonomous { get; set; }        
        
        /// <summary>
        /// Determines the type of movement that follows
        /// </summary>
        [MessageProperty]
        public MovementType MovementType { get; set; }        
        
        /// <summary>
        /// Options for this movement (sticky, standing long jump)
        /// </summary>
        [MessageProperty]
        public MovementOption OptionFlags { get; set; }        
        
        /// <summary>
        /// Current stance
        /// </summary>
        [MessageProperty]
        public StanceMode Stance { get; set; }        
        
        /// <summary>
        /// Set of motion data
        /// </summary>
        [MessageProperty]
        public InterpertedMotionState State { get; } = new InterpertedMotionState();
        
        /// <summary>
        /// object to stick to
        /// </summary>
        [MessageProperty]
        public uint StickyObject { get; set; }        
        
        /// <summary>
        /// The id of target that's being moved to
        /// </summary>
        [MessageProperty]
        public uint Target { get; set; }        
        
        /// <summary>
        /// the location of the target in the world
        /// </summary>
        [MessageProperty]
        public Origin Origin { get; } = new Origin();
        
        /// <summary>
        /// Set of movement parameters
        /// </summary>
        [MessageProperty]
        public MoveToMovementParameters MoveToParameters { get; } = new MoveToMovementParameters();
        
        /// <summary>
        /// Run speed of the moving object
        /// </summary>
        [MessageProperty]
        public float MyRunRate { get; set; }        
        
        /// <summary>
        /// Heading of the target to turn to, this is used instead of the desiredHeading in the parameters
        /// </summary>
        [MessageProperty]
        public float DesiredHeading { get; set; }        
        
        /// <summary>
        /// Set of movement parameters
        /// </summary>
        [MessageProperty]
        public TurnToMovementParameters TurnToParameters { get; } = new TurnToMovementParameters();
        


        public void Unpack(BinaryReader reader)
        {
            ObjectMovementSequence = reader.ReadUInt16();
            ObjectServerControlSequence = reader.ReadUInt16();
            Autonomous = reader.ReadUInt16();
            reader.Align();
            MovementType = (MovementType)reader.ReadByte();
            OptionFlags = (MovementOption)reader.ReadByte();
            Stance = (StanceMode)reader.ReadUInt16();
            switch(MovementType)
            {
                case MovementType.InterpertedMotionState:
                    State.Unpack(reader);
                    if((OptionFlags & MovementOption.StickToObject) != 0)
                    {
                        StickyObject = reader.ReadUInt32();
                    }
                break;
                case MovementType.MoveToObject:
                    Target = reader.ReadUInt32();
                    Origin.Unpack(reader);
                    MoveToParameters.Unpack(reader);
                    MyRunRate = reader.ReadSingle();
                break;
                case MovementType.MoveToPosition:
                    Origin.Unpack(reader);
                    MoveToParameters.Unpack(reader);
                    MyRunRate = reader.ReadSingle();
                break;
                case MovementType.TurnToObject:
                    Target = reader.ReadUInt32();
                    DesiredHeading = reader.ReadSingle();
                    TurnToParameters.Unpack(reader);
                break;
                case MovementType.TurnToPosition:
                    TurnToParameters.Unpack(reader);
                break;
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(ObjectMovementSequence);
            writer.Write(ObjectServerControlSequence);
            writer.Write(Autonomous);
            writer.Align();
            writer.Write((byte)MovementType);
            writer.Write((byte)OptionFlags);
            writer.Write((ushort)Stance);
            switch(MovementType)
            {
                case MovementType.InterpertedMotionState:
                    State.Pack(writer);
                    if((OptionFlags & MovementOption.StickToObject) != 0)
                    {
                        writer.Write(StickyObject);
                    }
                break;
                case MovementType.MoveToObject:
                    writer.Write(Target);
                    Origin.Pack(writer);
                    MoveToParameters.Pack(writer);
                    writer.Write(MyRunRate);
                break;
                case MovementType.MoveToPosition:
                    Origin.Pack(writer);
                    MoveToParameters.Pack(writer);
                    writer.Write(MyRunRate);
                break;
                case MovementType.TurnToObject:
                    writer.Write(Target);
                    writer.Write(DesiredHeading);
                    TurnToParameters.Pack(writer);
                break;
                case MovementType.TurnToPosition:
                    TurnToParameters.Pack(writer);
                break;
            }

        }


    }
}
