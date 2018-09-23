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
    /// Contains information for animations and general free motion
    /// </summary>
    public class InterpertedMotionState : IPackable
    {
        [MessageProperty]
        public uint MaskFlags { get; set; }        
        
        
        [MessageProperty]
        public uint CommandListLength { get; set; }        
        
        
        /// <summary>
        /// Stance.  If not present, defaults to 0x3D (NonCombat)
        /// </summary>
        [MessageProperty]
        public StanceMode CurrentStyle { get; set; }        
        
        /// <summary>
        /// Command for our forward movement. If not present, defaults to 0x03 (Ready)
        /// </summary>
        [MessageProperty]
        public MovementCommand ForwardCommand { get; set; }        
        
        /// <summary>
        /// Command for our sidestep movememnt. If not present, defaults to 0x00
        /// </summary>
        [MessageProperty]
        public MovementCommand SidestepCommand { get; set; }        
        
        /// <summary>
        /// Command for our turn movememnt. If not present, defaults to 0x00
        /// </summary>
        [MessageProperty]
        public MovementCommand TurnCommand { get; set; }        
        
        /// <summary>
        /// Forward movement speed. If not present, defaults to 1.0
        /// </summary>
        [MessageProperty]
        public float ForwardSpeed { get; set; }        
        
        /// <summary>
        /// Sidestep movement speed. If not present, defaults to 1.0
        /// </summary>
        [MessageProperty]
        public float SidestepSpeed { get; set; }        
        
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
            MaskFlags = (uint)(Flags & 0x7F);
            CommandListLength = (uint)(Flags >> 7 & 0x7F);
            if((MaskFlags & 0x00000001) != 0)
            {
                CurrentStyle = (StanceMode)reader.ReadUInt16();
            }
            if((MaskFlags & 0x00000002) != 0)
            {
                ForwardCommand = (MovementCommand)reader.ReadUInt16();
            }
            if((MaskFlags & 0x00000008) != 0)
            {
                SidestepCommand = (MovementCommand)reader.ReadUInt16();
            }
            if((MaskFlags & 0x00000020) != 0)
            {
                TurnCommand = (MovementCommand)reader.ReadUInt16();
            }
            if((MaskFlags & 0x00000004) != 0)
            {
                ForwardSpeed = reader.ReadSingle();
            }
            if((MaskFlags & 0x00000010) != 0)
            {
                SidestepSpeed = reader.ReadSingle();
            }
            if((MaskFlags & 0x00000040) != 0)
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
            reader.Align();

        }

        public void Pack(BinaryWriter writer)
        {
            uint Flags = 0;
            Flags |= (uint)(MaskFlags & 0x7F);
            Flags |= (uint)(CommandListLength & 0x7F << 7);
            writer.Write(Flags);
            if((MaskFlags & 0x00000001) != 0)
            {
                writer.Write((ushort)CurrentStyle);
            }
            if((MaskFlags & 0x00000002) != 0)
            {
                writer.Write((ushort)ForwardCommand);
            }
            if((MaskFlags & 0x00000008) != 0)
            {
                writer.Write((ushort)SidestepCommand);
            }
            if((MaskFlags & 0x00000020) != 0)
            {
                writer.Write((ushort)TurnCommand);
            }
            if((MaskFlags & 0x00000004) != 0)
            {
                writer.Write(ForwardSpeed);
            }
            if((MaskFlags & 0x00000010) != 0)
            {
                writer.Write(SidestepSpeed);
            }
            if((MaskFlags & 0x00000040) != 0)
            {
                writer.Write(TurnSpeed);
            }
            for(int i = 0; i < CommandListLength; i++)
            {
                Commands[i].Pack(writer);
            }
            writer.Align();

        }


    }
}
