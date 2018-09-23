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
    /// Data related to the movement of the object sent from a client
    /// </summary>
    public class RawMotionState : IPackable
    {
        /// <summary>
        /// Sequence of the animation.
        /// </summary>
        [MessageProperty]
        public ushort CommandListLength { get; set; }        
        
        
        [MessageProperty]
        public uint CurrentHoldkey { get; set; }        
        
        /// <summary>
        /// Current stance.  If not present, defaults to 0x3D (NonCombat)
        /// </summary>
        [MessageProperty]
        public StanceMode CurrentStyle { get; set; }        
        
        /// <summary>
        /// Command for our forward movement. If not present, defaults to 0x03 (Ready)
        /// </summary>
        [MessageProperty]
        public MovementCommand ForwardCommand { get; set; }        
        
        /// <summary>
        /// Whether forward key is being held
        /// </summary>
        [MessageProperty]
        public uint ForwardHoldkey { get; set; }        
        
        /// <summary>
        /// Forward movement speed. If not present, defaults to 1.0
        /// </summary>
        [MessageProperty]
        public float ForwardSpeed { get; set; }        
        
        /// <summary>
        /// Command for our sidestep movememnt. If not present, defaults to 0x00
        /// </summary>
        [MessageProperty]
        public MovementCommand SidestepCommand { get; set; }        
        
        /// <summary>
        /// Whether sidestep key is being held
        /// </summary>
        [MessageProperty]
        public uint SidestepHoldkey { get; set; }        
        
        /// <summary>
        /// Sidestep movement speed. If not present, defaults to 1.0
        /// </summary>
        [MessageProperty]
        public float SidestepSpeed { get; set; }        
        
        /// <summary>
        /// Command for our turn movememnt. If not present, defaults to 0x00
        /// </summary>
        [MessageProperty]
        public MovementCommand TurnCommand { get; set; }        
        
        /// <summary>
        /// Whether turn key is being held
        /// </summary>
        [MessageProperty]
        public uint TurnHoldkey { get; set; }        
        
        /// <summary>
        /// Turn movement speed. If not present, defaults to 1.0
        /// </summary>
        [MessageProperty]
        public float TurnSpeed { get; set; }        
        
        [MessageProperty]
        public List<LListData> Commands { get; } = new List<LListData>();
        


        public void Unpack(BinaryReader reader)
        {
            uint Flags = reader.ReadUInt32();
            CommandListLength = (ushort)(Flags >> 11 & 0xF8);
            if((Flags & 0x00000001) != 0)
            {
                CurrentHoldkey = reader.ReadUInt32();
            }
            if((Flags & 0x00000002) != 0)
            {
                CurrentStyle = (StanceMode)reader.ReadUInt16();
            }
            if((Flags & 0x00000004) != 0)
            {
                ForwardCommand = (MovementCommand)reader.ReadUInt16();
            }
            if((Flags & 0x0000008) != 0)
            {
                ForwardHoldkey = reader.ReadUInt32();
            }
            if((Flags & 0x00000010) != 0)
            {
                ForwardSpeed = reader.ReadSingle();
            }
            if((Flags & 0x00000020) != 0)
            {
                SidestepCommand = (MovementCommand)reader.ReadUInt16();
            }
            if((Flags & 0x00000040) != 0)
            {
                SidestepHoldkey = reader.ReadUInt32();
            }
            if((Flags & 0x00000080) != 0)
            {
                SidestepSpeed = reader.ReadSingle();
            }
            if((Flags & 0x00000100) != 0)
            {
                TurnCommand = (MovementCommand)reader.ReadUInt16();
            }
            if((Flags & 0x00000200) != 0)
            {
                TurnHoldkey = reader.ReadUInt32();
            }
            if((Flags & 0x00000400) != 0)
            {
                TurnSpeed = reader.ReadSingle();
            }
            Commands.Clear();
            for(int i = 0; i < CommandListLength; i++)
            {
                LListData newItem = new LListData();
                newItem.Unpack(reader);
                Commands.Add(newItem);
            }

        }

        public void Pack(BinaryWriter writer)
        {
            uint Flags = 0;
            Flags |= (uint)(CommandListLength & 0xF8 << 11);
            writer.Write(Flags);
            if((Flags & 0x00000001) != 0)
            {
                writer.Write(CurrentHoldkey);
            }
            if((Flags & 0x00000002) != 0)
            {
                writer.Write((ushort)CurrentStyle);
            }
            if((Flags & 0x00000004) != 0)
            {
                writer.Write((ushort)ForwardCommand);
            }
            if((Flags & 0x0000008) != 0)
            {
                writer.Write(ForwardHoldkey);
            }
            if((Flags & 0x00000010) != 0)
            {
                writer.Write(ForwardSpeed);
            }
            if((Flags & 0x00000020) != 0)
            {
                writer.Write((ushort)SidestepCommand);
            }
            if((Flags & 0x00000040) != 0)
            {
                writer.Write(SidestepHoldkey);
            }
            if((Flags & 0x00000080) != 0)
            {
                writer.Write(SidestepSpeed);
            }
            if((Flags & 0x00000100) != 0)
            {
                writer.Write((ushort)TurnCommand);
            }
            if((Flags & 0x00000200) != 0)
            {
                writer.Write(TurnHoldkey);
            }
            if((Flags & 0x00000400) != 0)
            {
                writer.Write(TurnSpeed);
            }
            for(int i = 0; i < CommandListLength; i++)
            {
                Commands[i].Pack(writer);
            }

        }


    }
}
