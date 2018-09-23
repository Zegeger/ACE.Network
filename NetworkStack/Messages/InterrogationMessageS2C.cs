////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    /// <summary>
    /// Add or update a dat file Resource.
    /// </summary>
    public class InterrogationMessageS2C : Message
    {
        [MessageProperty]
        public uint ServersRegion { get; set; }        
        
        [MessageProperty]
        public uint NameRuleLanguage { get; set; }        
        
        [MessageProperty]
        public uint ProductID { get; set; }        
        
        /// <summary>
        /// Number of supported languanges
        /// </summary>
        [MessageProperty]
        public uint SupportedLanguagesCount { get; set; }        
        
        [MessageProperty]
        public List<uint> SupportedLanguages { get; } = new List<uint>();
        


        public InterrogationMessageS2C() : base((MessageType)0xF7E5, MessageDirection.ServerToClient, (Queues)0x00000005)
        { }

        public InterrogationMessageS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ServersRegion = reader.ReadUInt32();
            NameRuleLanguage = reader.ReadUInt32();
            ProductID = reader.ReadUInt32();
            SupportedLanguagesCount = reader.ReadUInt32();
            SupportedLanguages.Clear();
            for(int i = 0; i < SupportedLanguagesCount; i++)
            {
                SupportedLanguages.Add(reader.ReadUInt32());
            }

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ServersRegion);
            writer.Write(NameRuleLanguage);
            writer.Write(ProductID);
            writer.Write(SupportedLanguagesCount);
            for(int i = 0; i < SupportedLanguagesCount; i++)
            {
                writer.Write(SupportedLanguages[i]);
            }

        }


    }
}
