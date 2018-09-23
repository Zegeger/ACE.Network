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
    public class Emote : IPackable
    {
        [MessageProperty]
        public EmoteType Type { get; set; }        
        
        [MessageProperty]
        public float Delay { get; set; }        
        
        [MessageProperty]
        public float Extent { get; set; }        
        
        [MessageProperty]
        public string Msg { get; set; }        
        
        [MessageProperty]
        public uint Amount { get; set; }        
        
        [MessageProperty]
        public uint Stat { get; set; }        
        
        [MessageProperty]
        public double Percent { get; set; }        
        
        [MessageProperty]
        public uint Min { get; set; }        
        
        [MessageProperty]
        public uint Max { get; set; }        
        
        [MessageProperty]
        public ulong Amount64 { get; set; }        
        
        [MessageProperty]
        public ulong Heroxp64 { get; set; }        
        
        [MessageProperty]
        public uint SpellID { get; set; }        
        
        [MessageProperty]
        public CreationProfile Cprof { get; } = new CreationProfile();
        
        /// <summary>
        /// Over 8 is invalid
        /// </summary>
        [MessageProperty]
        public int WealthRating { get; set; }        
        
        [MessageProperty]
        public int TreasureClass { get; set; }        
        
        /// <summary>
        /// Valid values are 0 to 3 
        /// </summary>
        [MessageProperty]
        public int TreasureType { get; set; }        
        
        [MessageProperty]
        public uint Motion { get; set; }        
        
        [MessageProperty]
        public Frame Frame { get; } = new Frame();
        
        [MessageProperty]
        public uint Pscript { get; set; }        
        
        [MessageProperty]
        public uint Sound { get; set; }        
        
        [MessageProperty]
        public string Teststring { get; set; }        
        
        [MessageProperty]
        public ulong Min64 { get; set; }        
        
        [MessageProperty]
        public ulong Max64 { get; set; }        
        
        [MessageProperty]
        public double Fmin { get; set; }        
        
        [MessageProperty]
        public double Fmax { get; set; }        
        
        [MessageProperty]
        public bool Display { get; set; }        
        
        [MessageProperty]
        public Position Position { get; } = new Position();
        


        public void Unpack(BinaryReader reader)
        {
            Type = (EmoteType)reader.ReadUInt32();
            Delay = reader.ReadSingle();
            Extent = reader.ReadSingle();
            switch(Type)
            {
                case EmoteType.Act_EmoteType:
                case EmoteType.Say_EmoteType:
                case EmoteType.Tell_EmoteType:
                case EmoteType.TextDirect_EmoteType:
                case EmoteType.WorldBroadcast_EmoteType:
                case EmoteType.LocalBroadcast_EmoteType:
                case EmoteType.DirectBroadcast_EmoteType:
                case EmoteType.UpdateQuest_EmoteType:
                case EmoteType.InqQuest_EmoteType:
                case EmoteType.StampQuest_EmoteType:
                case EmoteType.StartEvent_EmoteType:
                case EmoteType.StopEvent_EmoteType:
                case EmoteType.BLog_EmoteType:
                case EmoteType.AdminSpam_EmoteType:
                case EmoteType.EraseQuest_EmoteType:
                case EmoteType.InqEvent_EmoteType:
                case EmoteType.InqFellowQuest_EmoteType:
                case EmoteType.UpdateFellowQuest_EmoteType:
                case EmoteType.StampFellowQuest_EmoteType:
                case EmoteType.TellFellow_EmoteType:
                case EmoteType.FellowBroadcast_EmoteType:
                case EmoteType.Goto_EmoteType:
                case EmoteType.PopUp_EmoteType:
                case EmoteType.UpdateMyQuest_EmoteType:
                case EmoteType.InqMyQuest_EmoteType:
                case EmoteType.StampMyQuest_EmoteType:
                case EmoteType.EraseMyQuest_EmoteType:
                case EmoteType.LocalSignal_EmoteType:
                case EmoteType.InqContractsFull_EmoteType:
                    Msg = reader.ReadString16L();
                break;
                case EmoteType.DecrementQuest_EmoteType:
                case EmoteType.IncrementQuest_EmoteType:
                case EmoteType.SetQuestCompletions_EmoteType:
                case EmoteType.DecrementMyQuest_EmoteType:
                case EmoteType.IncrementMyQuest_EmoteType:
                case EmoteType.SetMyQuestCompletions_EmoteType:
                case EmoteType.InqPackSpace_EmoteType:
                case EmoteType.InqQuestBitsOn_EmoteType:
                case EmoteType.InqQuestBitsOff_EmoteType:
                case EmoteType.InqMyQuestBitsOn_EmoteType:
                case EmoteType.InqMyQuestBitsOff_EmoteType:
                case EmoteType.SetQuestBitsOn_EmoteType:
                case EmoteType.SetQuestBitsOff_EmoteType:
                case EmoteType.SetMyQuestBitsOn_EmoteType:
                case EmoteType.SetMyQuestBitsOff_EmoteType:
                    Msg = reader.ReadString16L();
                    Amount = reader.ReadUInt32();
                break;
                case EmoteType.SetIntStat_EmoteType:
                case EmoteType.IncrementIntStat_EmoteType:
                case EmoteType.DecrementIntStat_EmoteType:
                case EmoteType.SetBoolStat_EmoteType:
                    Stat = reader.ReadUInt32();
                    Amount = reader.ReadUInt32();
                break;
                case EmoteType.SetInt64Stat_EmoteType:
                    Stat = reader.ReadUInt32();
                break;
                case EmoteType.SetFloatStat_EmoteType:
                    Stat = reader.ReadUInt32();
                    Percent = reader.ReadDouble();
                break;
                case EmoteType.InqQuestSolves_EmoteType:
                case EmoteType.InqFellowNum_EmoteType:
                case EmoteType.InqNumCharacterTitles_EmoteType:
                case EmoteType.InqMyQuestSolves_EmoteType:
                    Msg = reader.ReadString16L();
                    Min = reader.ReadUInt32();
                    Max = reader.ReadUInt32();
                break;
                case EmoteType.AwardXP_EmoteType:
                case EmoteType.AwardNoShareXP_EmoteType:
                    Amount64 = reader.ReadUInt64();
                    Heroxp64 = reader.ReadUInt64();
                break;
                case EmoteType.SpendLuminance_EmoteType:
                case EmoteType.AwardLuminance_EmoteType:
                    Amount64 = reader.ReadUInt64();
                break;
                case EmoteType.AddCharacterTitle_EmoteType:
                case EmoteType.AwardTrainingCredits_EmoteType:
                case EmoteType.InflictVitaePenalty_EmoteType:
                case EmoteType.RemoveVitaePenalty_EmoteType:
                case EmoteType.AddContract_EmoteType:
                case EmoteType.RemoveContract_EmoteType:
                    Amount = reader.ReadUInt32();
                break;
                case EmoteType.CastSpell_EmoteType:
                case EmoteType.CastSpellInstant_EmoteType:
                case EmoteType.TeachSpell_EmoteType:
                case EmoteType.PetCastSpellOnOwner_EmoteType:
                    SpellID = reader.ReadUInt32();
                break;
                case EmoteType.Give_EmoteType:
                case EmoteType.TakeItems_EmoteType:
                    Cprof.Unpack(reader);
                break;
                case EmoteType.InqOwnsItems_EmoteType:
                    Msg = reader.ReadString16L();
                    Cprof.Unpack(reader);
                break;
                case EmoteType.CreateTreasure_EmoteType:
                    WealthRating = reader.ReadInt32();
                    TreasureClass = reader.ReadInt32();
                    TreasureType = reader.ReadInt32();
                break;
                case EmoteType.Motion_EmoteType:
                case EmoteType.ForceMotion_EmoteType:
                    Motion = reader.ReadUInt32();
                break;
                case EmoteType.MoveHome_EmoteType:
                case EmoteType.Move_EmoteType:
                case EmoteType.Turn_EmoteType:
                case EmoteType.MoveToPos_EmoteType:
                    Frame.Unpack(reader);
                break;
                case EmoteType.PhysScript_EmoteType:
                    Pscript = reader.ReadUInt32();
                break;
                case EmoteType.Sound_EmoteType:
                    Sound = reader.ReadUInt32();
                break;
                case EmoteType.AwardSkillXP_EmoteType:
                case EmoteType.AwardSkillPoints_EmoteType:
                    Amount = reader.ReadUInt32();
                    Stat = reader.ReadUInt32();
                break;
                case EmoteType.UntrainSkill_EmoteType:
                    Stat = reader.ReadUInt32();
                break;
                case EmoteType.SetAltRacialSkills_EmoteType:
                    Amount = reader.ReadUInt32();
                break;
                case EmoteType.InqBoolStat_EmoteType:
                case EmoteType.InqSkillTrained_EmoteType:
                case EmoteType.InqSkillSpecialized_EmoteType:
                    Msg = reader.ReadString16L();
                    Stat = reader.ReadUInt32();
                break;
                case EmoteType.InqStringStat_EmoteType:
                case EmoteType.InqYesNo_EmoteType:
                    Msg = reader.ReadString16L();
                    Teststring = reader.ReadString16L();
                    Stat = reader.ReadUInt32();
                break;
                case EmoteType.InqIntStat_EmoteType:
                case EmoteType.InqAttributeStat_EmoteType:
                case EmoteType.InqRawAttributeStat_EmoteType:
                case EmoteType.InqSecondaryAttributeStat_EmoteType:
                case EmoteType.InqRawSecondaryAttributeStat_EmoteType:
                case EmoteType.InqSkillStat_EmoteType:
                case EmoteType.InqRawSkillStat_EmoteType:
                    Msg = reader.ReadString16L();
                    Min = reader.ReadUInt32();
                    Max = reader.ReadUInt32();
                    Stat = reader.ReadUInt32();
                break;
                case EmoteType.InqInt64Stat_EmoteType:
                    Msg = reader.ReadString16L();
                    Min64 = reader.ReadUInt64();
                    Max64 = reader.ReadUInt64();
                    Stat = reader.ReadUInt32();
                break;
                case EmoteType.InqFloatStat_EmoteType:
                    Msg = reader.ReadString16L();
                    Fmin = reader.ReadDouble();
                    Fmax = reader.ReadDouble();
                    Stat = reader.ReadUInt32();
                break;
                case EmoteType.AwardLevelProportionalXP_EmoteType:
                    Percent = reader.ReadDouble();
                    Min64 = reader.ReadUInt64();
                    Max64 = reader.ReadUInt64();
                break;
                case EmoteType.AwardLevelProportionalSkillXP_EmoteType:
                    Stat = reader.ReadUInt32();
                    Percent = reader.ReadDouble();
                    Min = reader.ReadUInt32();
                    Max = reader.ReadUInt32();
                    Display = reader.ReadBool32();
                break;
                case EmoteType.SetSanctuaryPosition_EmoteType:
                case EmoteType.TeleportTarget_EmoteType:
                case EmoteType.TeleportSelf_EmoteType:
                    Position.Unpack(reader);
                break;
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Type);
            writer.Write(Delay);
            writer.Write(Extent);
            switch(Type)
            {
                case EmoteType.Act_EmoteType:
                case EmoteType.Say_EmoteType:
                case EmoteType.Tell_EmoteType:
                case EmoteType.TextDirect_EmoteType:
                case EmoteType.WorldBroadcast_EmoteType:
                case EmoteType.LocalBroadcast_EmoteType:
                case EmoteType.DirectBroadcast_EmoteType:
                case EmoteType.UpdateQuest_EmoteType:
                case EmoteType.InqQuest_EmoteType:
                case EmoteType.StampQuest_EmoteType:
                case EmoteType.StartEvent_EmoteType:
                case EmoteType.StopEvent_EmoteType:
                case EmoteType.BLog_EmoteType:
                case EmoteType.AdminSpam_EmoteType:
                case EmoteType.EraseQuest_EmoteType:
                case EmoteType.InqEvent_EmoteType:
                case EmoteType.InqFellowQuest_EmoteType:
                case EmoteType.UpdateFellowQuest_EmoteType:
                case EmoteType.StampFellowQuest_EmoteType:
                case EmoteType.TellFellow_EmoteType:
                case EmoteType.FellowBroadcast_EmoteType:
                case EmoteType.Goto_EmoteType:
                case EmoteType.PopUp_EmoteType:
                case EmoteType.UpdateMyQuest_EmoteType:
                case EmoteType.InqMyQuest_EmoteType:
                case EmoteType.StampMyQuest_EmoteType:
                case EmoteType.EraseMyQuest_EmoteType:
                case EmoteType.LocalSignal_EmoteType:
                case EmoteType.InqContractsFull_EmoteType:
                    writer.WriteString16L(Msg);
                break;
                case EmoteType.DecrementQuest_EmoteType:
                case EmoteType.IncrementQuest_EmoteType:
                case EmoteType.SetQuestCompletions_EmoteType:
                case EmoteType.DecrementMyQuest_EmoteType:
                case EmoteType.IncrementMyQuest_EmoteType:
                case EmoteType.SetMyQuestCompletions_EmoteType:
                case EmoteType.InqPackSpace_EmoteType:
                case EmoteType.InqQuestBitsOn_EmoteType:
                case EmoteType.InqQuestBitsOff_EmoteType:
                case EmoteType.InqMyQuestBitsOn_EmoteType:
                case EmoteType.InqMyQuestBitsOff_EmoteType:
                case EmoteType.SetQuestBitsOn_EmoteType:
                case EmoteType.SetQuestBitsOff_EmoteType:
                case EmoteType.SetMyQuestBitsOn_EmoteType:
                case EmoteType.SetMyQuestBitsOff_EmoteType:
                    writer.WriteString16L(Msg);
                    writer.Write(Amount);
                break;
                case EmoteType.SetIntStat_EmoteType:
                case EmoteType.IncrementIntStat_EmoteType:
                case EmoteType.DecrementIntStat_EmoteType:
                case EmoteType.SetBoolStat_EmoteType:
                    writer.Write(Stat);
                    writer.Write(Amount);
                break;
                case EmoteType.SetInt64Stat_EmoteType:
                    writer.Write(Stat);
                break;
                case EmoteType.SetFloatStat_EmoteType:
                    writer.Write(Stat);
                    writer.Write(Percent);
                break;
                case EmoteType.InqQuestSolves_EmoteType:
                case EmoteType.InqFellowNum_EmoteType:
                case EmoteType.InqNumCharacterTitles_EmoteType:
                case EmoteType.InqMyQuestSolves_EmoteType:
                    writer.WriteString16L(Msg);
                    writer.Write(Min);
                    writer.Write(Max);
                break;
                case EmoteType.AwardXP_EmoteType:
                case EmoteType.AwardNoShareXP_EmoteType:
                    writer.Write(Amount64);
                    writer.Write(Heroxp64);
                break;
                case EmoteType.SpendLuminance_EmoteType:
                case EmoteType.AwardLuminance_EmoteType:
                    writer.Write(Amount64);
                break;
                case EmoteType.AddCharacterTitle_EmoteType:
                case EmoteType.AwardTrainingCredits_EmoteType:
                case EmoteType.InflictVitaePenalty_EmoteType:
                case EmoteType.RemoveVitaePenalty_EmoteType:
                case EmoteType.AddContract_EmoteType:
                case EmoteType.RemoveContract_EmoteType:
                    writer.Write(Amount);
                break;
                case EmoteType.CastSpell_EmoteType:
                case EmoteType.CastSpellInstant_EmoteType:
                case EmoteType.TeachSpell_EmoteType:
                case EmoteType.PetCastSpellOnOwner_EmoteType:
                    writer.Write(SpellID);
                break;
                case EmoteType.Give_EmoteType:
                case EmoteType.TakeItems_EmoteType:
                    Cprof.Pack(writer);
                break;
                case EmoteType.InqOwnsItems_EmoteType:
                    writer.WriteString16L(Msg);
                    Cprof.Pack(writer);
                break;
                case EmoteType.CreateTreasure_EmoteType:
                    writer.Write(WealthRating);
                    writer.Write(TreasureClass);
                    writer.Write(TreasureType);
                break;
                case EmoteType.Motion_EmoteType:
                case EmoteType.ForceMotion_EmoteType:
                    writer.Write(Motion);
                break;
                case EmoteType.MoveHome_EmoteType:
                case EmoteType.Move_EmoteType:
                case EmoteType.Turn_EmoteType:
                case EmoteType.MoveToPos_EmoteType:
                    Frame.Pack(writer);
                break;
                case EmoteType.PhysScript_EmoteType:
                    writer.Write(Pscript);
                break;
                case EmoteType.Sound_EmoteType:
                    writer.Write(Sound);
                break;
                case EmoteType.AwardSkillXP_EmoteType:
                case EmoteType.AwardSkillPoints_EmoteType:
                    writer.Write(Amount);
                    writer.Write(Stat);
                break;
                case EmoteType.UntrainSkill_EmoteType:
                    writer.Write(Stat);
                break;
                case EmoteType.SetAltRacialSkills_EmoteType:
                    writer.Write(Amount);
                break;
                case EmoteType.InqBoolStat_EmoteType:
                case EmoteType.InqSkillTrained_EmoteType:
                case EmoteType.InqSkillSpecialized_EmoteType:
                    writer.WriteString16L(Msg);
                    writer.Write(Stat);
                break;
                case EmoteType.InqStringStat_EmoteType:
                case EmoteType.InqYesNo_EmoteType:
                    writer.WriteString16L(Msg);
                    writer.WriteString16L(Teststring);
                    writer.Write(Stat);
                break;
                case EmoteType.InqIntStat_EmoteType:
                case EmoteType.InqAttributeStat_EmoteType:
                case EmoteType.InqRawAttributeStat_EmoteType:
                case EmoteType.InqSecondaryAttributeStat_EmoteType:
                case EmoteType.InqRawSecondaryAttributeStat_EmoteType:
                case EmoteType.InqSkillStat_EmoteType:
                case EmoteType.InqRawSkillStat_EmoteType:
                    writer.WriteString16L(Msg);
                    writer.Write(Min);
                    writer.Write(Max);
                    writer.Write(Stat);
                break;
                case EmoteType.InqInt64Stat_EmoteType:
                    writer.WriteString16L(Msg);
                    writer.Write(Min64);
                    writer.Write(Max64);
                    writer.Write(Stat);
                break;
                case EmoteType.InqFloatStat_EmoteType:
                    writer.WriteString16L(Msg);
                    writer.Write(Fmin);
                    writer.Write(Fmax);
                    writer.Write(Stat);
                break;
                case EmoteType.AwardLevelProportionalXP_EmoteType:
                    writer.Write(Percent);
                    writer.Write(Min64);
                    writer.Write(Max64);
                break;
                case EmoteType.AwardLevelProportionalSkillXP_EmoteType:
                    writer.Write(Stat);
                    writer.Write(Percent);
                    writer.Write(Min);
                    writer.Write(Max);
                    writer.WriteBool32(Display);
                break;
                case EmoteType.SetSanctuaryPosition_EmoteType:
                case EmoteType.TeleportTarget_EmoteType:
                case EmoteType.TeleportSelf_EmoteType:
                    Position.Pack(writer);
                break;
            }

        }


    }
}
