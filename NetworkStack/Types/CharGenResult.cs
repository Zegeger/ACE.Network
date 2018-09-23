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
    /// Data for a character creation
    /// </summary>
    public class CharGenResult : IPackable
    {
        [MessageProperty]
        public HeritageGroup HeritageGroup { get; set; }        
        
        [MessageProperty]
        public Gender Gender { get; set; }        
        
        [MessageProperty]
        public uint EyesStrip { get; set; }        
        
        [MessageProperty]
        public uint NoseStrip { get; set; }        
        
        [MessageProperty]
        public uint MouthStrip { get; set; }        
        
        [MessageProperty]
        public uint HairColor { get; set; }        
        
        [MessageProperty]
        public uint EyeColor { get; set; }        
        
        [MessageProperty]
        public uint HairStyle { get; set; }        
        
        [MessageProperty]
        public uint HeadgearStyle { get; set; }        
        
        [MessageProperty]
        public uint HeadgearColor { get; set; }        
        
        [MessageProperty]
        public uint ShirtStyle { get; set; }        
        
        [MessageProperty]
        public uint ShirtColor { get; set; }        
        
        [MessageProperty]
        public uint TrousersStyle { get; set; }        
        
        [MessageProperty]
        public uint TrousersColor { get; set; }        
        
        [MessageProperty]
        public uint FootwearStyle { get; set; }        
        
        [MessageProperty]
        public uint FootwearColor { get; set; }        
        
        [MessageProperty]
        public ulong SkinShade { get; set; }        
        
        [MessageProperty]
        public ulong HairShade { get; set; }        
        
        [MessageProperty]
        public ulong HeadgearShade { get; set; }        
        
        [MessageProperty]
        public ulong ShirtShade { get; set; }        
        
        [MessageProperty]
        public ulong TrousersShade { get; set; }        
        
        [MessageProperty]
        public ulong FootwearShade { get; set; }        
        
        [MessageProperty]
        public uint TemplateNum { get; set; }        
        
        [MessageProperty]
        public uint Strength { get; set; }        
        
        [MessageProperty]
        public uint Endurance { get; set; }        
        
        [MessageProperty]
        public uint Coordination { get; set; }        
        
        [MessageProperty]
        public uint Quickness { get; set; }        
        
        [MessageProperty]
        public uint Focus { get; set; }        
        
        [MessageProperty]
        public uint Self { get; set; }        
        
        [MessageProperty]
        public uint Slot { get; set; }        
        
        [MessageProperty]
        public uint ClassID { get; set; }        
        
        [MessageProperty]
        public uint NumSkills { get; set; }        
        
        /// <summary>
        /// Whether Skill at index is untrained, trained, or specialized
        /// </summary>
        [MessageProperty]
        public List<SkillState> Skills { get; } = new List<SkillState>();
        
        [MessageProperty]
        public string Name { get; set; }        
        
        [MessageProperty]
        public uint StartArea { get; set; }        
        
        [MessageProperty]
        public uint IsAdmin { get; set; }        
        
        [MessageProperty]
        public uint IsEnvoy { get; set; }        
        
        /// <summary>
        /// Seems to be the total of heritageGroup, gender, eyesStrip, noseStrip, mouthStrip, hairColor, eyeColor, hairStyle, headgearStyle, shirtStyle, trousersStyle, footwearStyle, templateNum, strength, endurance, coordination, quickness, focus, self. Perhaps used for some kind of validation?
        /// </summary>
        [MessageProperty]
        public uint Validation { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            var temp1 = reader.ReadUInt32(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 1)
            {
                throw new Exception("Recieved value different from static on CharGenResult, expected: 1, actual " + temp1);
            }
#endif
            HeritageGroup = (HeritageGroup)reader.ReadUInt32();
            Gender = (Gender)reader.ReadUInt32();
            EyesStrip = reader.ReadUInt32();
            NoseStrip = reader.ReadUInt32();
            MouthStrip = reader.ReadUInt32();
            HairColor = reader.ReadUInt32();
            EyeColor = reader.ReadUInt32();
            HairStyle = reader.ReadUInt32();
            HeadgearStyle = reader.ReadUInt32();
            HeadgearColor = reader.ReadUInt32();
            ShirtStyle = reader.ReadUInt32();
            ShirtColor = reader.ReadUInt32();
            TrousersStyle = reader.ReadUInt32();
            TrousersColor = reader.ReadUInt32();
            FootwearStyle = reader.ReadUInt32();
            FootwearColor = reader.ReadUInt32();
            SkinShade = reader.ReadUInt64();
            HairShade = reader.ReadUInt64();
            HeadgearShade = reader.ReadUInt64();
            ShirtShade = reader.ReadUInt64();
            TrousersShade = reader.ReadUInt64();
            FootwearShade = reader.ReadUInt64();
            TemplateNum = reader.ReadUInt32();
            Strength = reader.ReadUInt32();
            Endurance = reader.ReadUInt32();
            Coordination = reader.ReadUInt32();
            Quickness = reader.ReadUInt32();
            Focus = reader.ReadUInt32();
            Self = reader.ReadUInt32();
            Slot = reader.ReadUInt32();
            ClassID = reader.ReadUInt32();
            NumSkills = reader.ReadUInt32();
            Skills.Clear();
            for(int i = 0; i < NumSkills; i++)
            {
                Skills.Add((SkillState)reader.ReadUInt32());
            }
            Name = reader.ReadString16L();
            StartArea = reader.ReadUInt32();
            IsAdmin = reader.ReadUInt32();
            IsEnvoy = reader.ReadUInt32();
            Validation = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)1); // Unused value
            writer.Write((uint)HeritageGroup);
            writer.Write((uint)Gender);
            writer.Write(EyesStrip);
            writer.Write(NoseStrip);
            writer.Write(MouthStrip);
            writer.Write(HairColor);
            writer.Write(EyeColor);
            writer.Write(HairStyle);
            writer.Write(HeadgearStyle);
            writer.Write(HeadgearColor);
            writer.Write(ShirtStyle);
            writer.Write(ShirtColor);
            writer.Write(TrousersStyle);
            writer.Write(TrousersColor);
            writer.Write(FootwearStyle);
            writer.Write(FootwearColor);
            writer.Write(SkinShade);
            writer.Write(HairShade);
            writer.Write(HeadgearShade);
            writer.Write(ShirtShade);
            writer.Write(TrousersShade);
            writer.Write(FootwearShade);
            writer.Write(TemplateNum);
            writer.Write(Strength);
            writer.Write(Endurance);
            writer.Write(Coordination);
            writer.Write(Quickness);
            writer.Write(Focus);
            writer.Write(Self);
            writer.Write(Slot);
            writer.Write(ClassID);
            writer.Write(NumSkills);
            for(int i = 0; i < NumSkills; i++)
            {
                writer.Write((uint)Skills[i]);
            }
            writer.WriteString16L(Name);
            writer.Write(StartArea);
            writer.Write(IsAdmin);
            writer.Write(IsEnvoy);
            writer.Write(Validation);

        }


    }
}
