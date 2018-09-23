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
    /// The OldPublicWeenieDesc structure defines an object's game behavior.
    /// </summary>
    public class OldPublicWeenieDesc : IPackable
    {
        /// <summary>
        /// game data flags
        /// </summary>
        [MessageProperty]
        public uint Header { get; set; }        
        
        /// <summary>
        /// object name
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        
        /// <summary>
        /// object weenie class id
        /// </summary>
        [MessageProperty]
        public ushort WeenieClassID { get; set; }        
        
        /// <summary>
        /// icon ResourceID (minus 0x06000000)
        /// </summary>
        [MessageProperty]
        public ushort IconID { get; set; }        
        
        /// <summary>
        /// object type
        /// </summary>
        [MessageProperty]
        public ObjectType Type { get; set; }        
        
        /// <summary>
        /// object behaviors
        /// </summary>
        [MessageProperty]
        public ObjectDescriptionFlag Bitfield { get; set; }        
        
        /// <summary>
        /// plural object name (if not specified, use <name> followed by 's' or 'es')
        /// </summary>
        [MessageProperty]
        public string PluralName { get; set; }        
        
        /// <summary>
        /// number of item slots
        /// </summary>
        [MessageProperty]
        public byte ItemsCapacity { get; set; }        
        
        /// <summary>
        /// number of pack slots
        /// </summary>
        [MessageProperty]
        public byte ContainerCapacity { get; set; }        
        
        /// <summary>
        /// object value
        /// </summary>
        [MessageProperty]
        public uint Value { get; set; }        
        
        [MessageProperty]
        public UsableType Useability { get; set; }        
        
        /// <summary>
        /// distance a player will walk to use an object
        /// </summary>
        [MessageProperty]
        public float UseRadius { get; set; }        
        
        /// <summary>
        /// the object categories this object may be used on
        /// </summary>
        [MessageProperty]
        public ObjectType TargetType { get; set; }        
        
        /// <summary>
        /// the type of highlight (outline) applied to the object's icon
        /// </summary>
        [MessageProperty]
        public IconEffect Effects { get; set; }        
        
        /// <summary>
        /// missile ammunition type
        /// </summary>
        [MessageProperty]
        public AmmoType AmmunitionType { get; set; }        
        
        /// <summary>
        /// the type of wieldable item this is
        /// </summary>
        [MessageProperty]
        public CombatUse CombatUse { get; set; }        
        
        /// <summary>
        /// the number of uses remaining for this item (also salvage quantity)
        /// </summary>
        [MessageProperty]
        public ushort Structure { get; set; }        
        
        /// <summary>
        /// the maximum number of uses possible for this item (also maximum salvage quantity)
        /// </summary>
        [MessageProperty]
        public ushort MaxStructure { get; set; }        
        
        /// <summary>
        /// the number of items in this stack of objects
        /// </summary>
        [MessageProperty]
        public ushort StackSize { get; set; }        
        
        /// <summary>
        /// the maximum number of items possible in this stack of objects
        /// </summary>
        [MessageProperty]
        public ushort MaxStackSize { get; set; }        
        
        /// <summary>
        /// the ID of the container holding this object
        /// </summary>
        [MessageProperty]
        public uint ContainerID { get; set; }        
        
        /// <summary>
        /// the ID of the creature equipping this object
        /// </summary>
        [MessageProperty]
        public uint WielderID { get; set; }        
        
        /// <summary>
        /// the potential equipment slots this object may be placed in
        /// </summary>
        [MessageProperty]
        public EquipMask ValidLocations { get; set; }        
        
        /// <summary>
        /// the actual equipment slots this object is currently placed in
        /// </summary>
        [MessageProperty]
        public EquipMask Location { get; set; }        
        
        /// <summary>
        /// the parts of the body this object protects
        /// </summary>
        [MessageProperty]
        public CoverageMask Priority { get; set; }        
        
        /// <summary>
        /// radar dot color
        /// </summary>
        [MessageProperty]
        public byte BlipColor { get; set; }        
        
        /// <summary>
        /// radar type
        /// </summary>
        [MessageProperty]
        public byte RadarEnum { get; set; }        
        
        [MessageProperty]
        public float ObviousDistance { get; set; }        
        
        [MessageProperty]
        public ushort Vndwcid { get; set; }        
        
        /// <summary>
        /// the spell cast by this object
        /// </summary>
        [MessageProperty]
        public ushort Spell { get; set; }        
        
        [MessageProperty]
        public uint HouseOwnerIID { get; set; }        
        
        [MessageProperty]
        public ushort PhysicsScript { get; set; }        
        
        /// <summary>
        /// the access control list for this dwelling object
        /// </summary>
        [MessageProperty]
        public RestrictionDB Restrictions { get; } = new RestrictionDB();
        
        /// <summary>
        /// the types of hooks this object may be placed on (-1 for hooks)
        /// </summary>
        [MessageProperty]
        public HookType HookType { get; set; }        
        
        /// <summary>
        /// what type of dwelling hook is this
        /// </summary>
        [MessageProperty]
        public HookType HookItemTypes { get; set; }        
        
        /// <summary>
        /// this player's monarch
        /// </summary>
        [MessageProperty]
        public uint Monarch { get; set; }        
        
        /// <summary>
        /// icon overlay ResourceID (minus 0x06000000)
        /// </summary>
        [MessageProperty]
        public ushort IconOverlay { get; set; }        
        
        /// <summary>
        /// the type of material this object is made of
        /// </summary>
        [MessageProperty]
        public MaterialType Material { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Header = reader.ReadUInt32();
            Name = reader.ReadString16L();
            WeenieClassID = reader.ReadUInt16();
            IconID = reader.ReadUInt16();
            Type = (ObjectType)reader.ReadUInt32();
            Bitfield = (ObjectDescriptionFlag)reader.ReadUInt32();
            if((Header & 0x00000001) != 0)
            {
                PluralName = reader.ReadString16L();
            }
            if((Header & 0x00000002) != 0)
            {
                ItemsCapacity = reader.ReadByte();
            }
            if((Header & 0x00000004) != 0)
            {
                ContainerCapacity = reader.ReadByte();
            }
            if((Header & 0x00000008) != 0)
            {
                Value = reader.ReadUInt32();
            }
            if((Header & 0x00000010) != 0)
            {
                Useability = (UsableType)reader.ReadUInt32();
            }
            if((Header & 0x00000020) != 0)
            {
                UseRadius = reader.ReadSingle();
            }
            if((Header & 0x00080000) != 0)
            {
                TargetType = (ObjectType)reader.ReadUInt32();
            }
            if((Header & 0x00000080) != 0)
            {
                Effects = (IconEffect)reader.ReadUInt32();
            }
            if((Header & 0x00000100) != 0)
            {
                AmmunitionType = (AmmoType)reader.ReadUInt16();
            }
            if((Header & 0x00000200) != 0)
            {
                CombatUse = (CombatUse)reader.ReadByte();
            }
            if((Header & 0x00000400) != 0)
            {
                Structure = reader.ReadUInt16();
            }
            if((Header & 0x00000800) != 0)
            {
                MaxStructure = reader.ReadUInt16();
            }
            if((Header & 0x00001000) != 0)
            {
                StackSize = reader.ReadUInt16();
            }
            if((Header & 0x00002000) != 0)
            {
                MaxStackSize = reader.ReadUInt16();
            }
            if((Header & 0x00004000) != 0)
            {
                ContainerID = reader.ReadUInt32();
            }
            if((Header & 0x00008000) != 0)
            {
                WielderID = reader.ReadUInt32();
            }
            if((Header & 0x00010000) != 0)
            {
                ValidLocations = (EquipMask)reader.ReadUInt32();
            }
            if((Header & 0x00020000) != 0)
            {
                Location = (EquipMask)reader.ReadUInt32();
            }
            if((Header & 0x00040000) != 0)
            {
                Priority = (CoverageMask)reader.ReadUInt32();
            }
            if((Header & 0x00100000) != 0)
            {
                BlipColor = reader.ReadByte();
            }
            if((Header & 0x00800000) != 0)
            {
                RadarEnum = reader.ReadByte();
            }
            if((Header & 0x01000000) != 0)
            {
                ObviousDistance = reader.ReadSingle();
            }
            if((Header & 0x00200000) != 0)
            {
                Vndwcid = reader.ReadUInt16();
            }
            if((Header & 0x00400000) != 0)
            {
                Spell = reader.ReadUInt16();
            }
            if((Header & 0x02000000) != 0)
            {
                HouseOwnerIID = reader.ReadUInt32();
            }
            if((Header & 0x08000000) != 0)
            {
                PhysicsScript = reader.ReadUInt16();
            }
            if((Header & 0x04000000) != 0)
            {
                Restrictions.Unpack(reader);
            }
            if((Header & 0x10000000) != 0)
            {
                HookType = (HookType)reader.ReadUInt16();
            }
            if((Header & 0x20000000) != 0)
            {
                HookItemTypes = (HookType)reader.ReadUInt16();
            }
            if((Header & 0x00000040) != 0)
            {
                Monarch = reader.ReadUInt32();
            }
            if((Header & 0x40000000) != 0)
            {
                IconOverlay = reader.ReadUInt16();
            }
            if((Header & 0x80000000) != 0)
            {
                Material = (MaterialType)reader.ReadUInt32();
            }
            reader.Align();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Header);
            writer.WriteString16L(Name);
            writer.Write(WeenieClassID);
            writer.Write(IconID);
            writer.Write((uint)Type);
            writer.Write((uint)Bitfield);
            if((Header & 0x00000001) != 0)
            {
                writer.WriteString16L(PluralName);
            }
            if((Header & 0x00000002) != 0)
            {
                writer.Write(ItemsCapacity);
            }
            if((Header & 0x00000004) != 0)
            {
                writer.Write(ContainerCapacity);
            }
            if((Header & 0x00000008) != 0)
            {
                writer.Write(Value);
            }
            if((Header & 0x00000010) != 0)
            {
                writer.Write((uint)Useability);
            }
            if((Header & 0x00000020) != 0)
            {
                writer.Write(UseRadius);
            }
            if((Header & 0x00080000) != 0)
            {
                writer.Write((uint)TargetType);
            }
            if((Header & 0x00000080) != 0)
            {
                writer.Write((uint)Effects);
            }
            if((Header & 0x00000100) != 0)
            {
                writer.Write((ushort)AmmunitionType);
            }
            if((Header & 0x00000200) != 0)
            {
                writer.Write((byte)CombatUse);
            }
            if((Header & 0x00000400) != 0)
            {
                writer.Write(Structure);
            }
            if((Header & 0x00000800) != 0)
            {
                writer.Write(MaxStructure);
            }
            if((Header & 0x00001000) != 0)
            {
                writer.Write(StackSize);
            }
            if((Header & 0x00002000) != 0)
            {
                writer.Write(MaxStackSize);
            }
            if((Header & 0x00004000) != 0)
            {
                writer.Write(ContainerID);
            }
            if((Header & 0x00008000) != 0)
            {
                writer.Write(WielderID);
            }
            if((Header & 0x00010000) != 0)
            {
                writer.Write((uint)ValidLocations);
            }
            if((Header & 0x00020000) != 0)
            {
                writer.Write((uint)Location);
            }
            if((Header & 0x00040000) != 0)
            {
                writer.Write((uint)Priority);
            }
            if((Header & 0x00100000) != 0)
            {
                writer.Write(BlipColor);
            }
            if((Header & 0x00800000) != 0)
            {
                writer.Write(RadarEnum);
            }
            if((Header & 0x01000000) != 0)
            {
                writer.Write(ObviousDistance);
            }
            if((Header & 0x00200000) != 0)
            {
                writer.Write(Vndwcid);
            }
            if((Header & 0x00400000) != 0)
            {
                writer.Write(Spell);
            }
            if((Header & 0x02000000) != 0)
            {
                writer.Write(HouseOwnerIID);
            }
            if((Header & 0x08000000) != 0)
            {
                writer.Write(PhysicsScript);
            }
            if((Header & 0x04000000) != 0)
            {
                Restrictions.Pack(writer);
            }
            if((Header & 0x10000000) != 0)
            {
                writer.Write((ushort)HookType);
            }
            if((Header & 0x20000000) != 0)
            {
                writer.Write((ushort)HookItemTypes);
            }
            if((Header & 0x00000040) != 0)
            {
                writer.Write(Monarch);
            }
            if((Header & 0x40000000) != 0)
            {
                writer.Write(IconOverlay);
            }
            if((Header & 0x80000000) != 0)
            {
                writer.Write((uint)Material);
            }
            writer.Align();

        }


    }
}
