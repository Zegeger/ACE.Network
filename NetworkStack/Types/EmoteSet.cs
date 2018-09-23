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
    public class EmoteSet : IPackable
    {
        [MessageProperty]
        public EmoteCategory Category { get; set; }        
        
        [MessageProperty]
        public float Probability { get; set; }        
        
        [MessageProperty]
        public uint ClassID { get; set; }        
        
        [MessageProperty]
        public uint Style { get; set; }        
        
        [MessageProperty]
        public uint Substyle { get; set; }        
        
        [MessageProperty]
        public string Quest { get; set; }        
        
        [MessageProperty]
        public uint VendorType { get; set; }        
        
        [MessageProperty]
        public float Minhealth { get; set; }        
        
        [MessageProperty]
        public float Maxhealth { get; set; }        
        
        /// <summary>
        /// List of emotes
        /// </summary>
        [MessageProperty]
        public PackableList<Emote> Emotes { get; } = new PackableList<Emote>(ReadEmotes, WriteEmotes);
        


        public void Unpack(BinaryReader reader)
        {
            Category = (EmoteCategory)reader.ReadUInt32();
            Probability = reader.ReadSingle();
            switch(Category)
            {
                case EmoteCategory.Refuse_EmoteCategory:
                case EmoteCategory.Give_EmoteCategory:
                    ClassID = reader.ReadUInt32();
                break;
                case EmoteCategory.HeartBeat_EmoteCategory:
                    Style = reader.ReadUInt32();
                    Substyle = reader.ReadUInt32();
                break;
                case EmoteCategory.QuestSuccess_EmoteCategory:
                case EmoteCategory.QuestFailure_EmoteCategory:
                case EmoteCategory.TestSuccess_EmoteCategory:
                case EmoteCategory.TestFailure_EmoteCategory:
                case EmoteCategory.EventSuccess_EmoteCategory:
                case EmoteCategory.EventFailure_EmoteCategory:
                case EmoteCategory.TestNoQuality_EmoteCategory:
                case EmoteCategory.QuestNoFellow_EmoteCategory:
                case EmoteCategory.TestNoFellow_EmoteCategory:
                case EmoteCategory.GotoSet_EmoteCategory:
                case EmoteCategory.NumFellowsSuccess_EmoteCategory:
                case EmoteCategory.NumFellowsFailure_EmoteCategory:
                case EmoteCategory.NumCharacterTitlesSuccess_EmoteCategory:
                case EmoteCategory.NumCharacterTitlesFailure_EmoteCategory:
                case EmoteCategory.ReceiveLocalSignal_EmoteCategory:
                case EmoteCategory.ReceiveTalkDirect_EmoteCategory:
                    Quest = reader.ReadString16L();
                break;
                case EmoteCategory.Vendor_EmoteCategory:
                    VendorType = reader.ReadUInt32();
                break;
                case EmoteCategory.WoundedTaunt_EmoteCategory:
                    Minhealth = reader.ReadSingle();
                    Maxhealth = reader.ReadSingle();
                break;
            }
            Emotes.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Category);
            writer.Write(Probability);
            switch(Category)
            {
                case EmoteCategory.Refuse_EmoteCategory:
                case EmoteCategory.Give_EmoteCategory:
                    writer.Write(ClassID);
                break;
                case EmoteCategory.HeartBeat_EmoteCategory:
                    writer.Write(Style);
                    writer.Write(Substyle);
                break;
                case EmoteCategory.QuestSuccess_EmoteCategory:
                case EmoteCategory.QuestFailure_EmoteCategory:
                case EmoteCategory.TestSuccess_EmoteCategory:
                case EmoteCategory.TestFailure_EmoteCategory:
                case EmoteCategory.EventSuccess_EmoteCategory:
                case EmoteCategory.EventFailure_EmoteCategory:
                case EmoteCategory.TestNoQuality_EmoteCategory:
                case EmoteCategory.QuestNoFellow_EmoteCategory:
                case EmoteCategory.TestNoFellow_EmoteCategory:
                case EmoteCategory.GotoSet_EmoteCategory:
                case EmoteCategory.NumFellowsSuccess_EmoteCategory:
                case EmoteCategory.NumFellowsFailure_EmoteCategory:
                case EmoteCategory.NumCharacterTitlesSuccess_EmoteCategory:
                case EmoteCategory.NumCharacterTitlesFailure_EmoteCategory:
                case EmoteCategory.ReceiveLocalSignal_EmoteCategory:
                case EmoteCategory.ReceiveTalkDirect_EmoteCategory:
                    writer.WriteString16L(Quest);
                break;
                case EmoteCategory.Vendor_EmoteCategory:
                    writer.Write(VendorType);
                break;
                case EmoteCategory.WoundedTaunt_EmoteCategory:
                    writer.Write(Minhealth);
                    writer.Write(Maxhealth);
                break;
            }
            Emotes.Pack(writer);

        }

        static Emote ReadEmotes(BinaryReader reader)
        {
            var item = new Emote();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteEmotes(BinaryWriter writer, Emote item)
        {
            item.Pack(writer);
        }
        

    }
}
