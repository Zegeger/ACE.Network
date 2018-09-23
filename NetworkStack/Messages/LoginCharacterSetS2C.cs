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
    /// The list of characters on the current account.
    /// </summary>
    public class LoginCharacterSetS2C : Message
    {
        [MessageProperty]
        public uint Status { get; set; }        
        
        /// <summary>
        /// The number of characters in the list.  Characters appear in the list ordered most-recently-used first, but are displayed alphabetically.
        /// </summary>
        [MessageProperty]
        public uint CharacterCount { get; set; }        
        
        [MessageProperty]
        public List<CharacterIdentity> Set { get; } = new List<CharacterIdentity>();
        
        /// <summary>
        /// This is a second list which goes into delSet, not sure what it is, deleted characters?
        /// </summary>
        [MessageProperty]
        public uint CharacterCount2 { get; set; }        
        
        [MessageProperty]
        public List<CharacterIdentity> Delset { get; } = new List<CharacterIdentity>();
        
        /// <summary>
        /// The total count of character slots.
        /// </summary>
        [MessageProperty]
        public uint NumAllowedCharacters { get; set; }        
        
        /// <summary>
        /// The name for this account.
        /// </summary>
        [MessageProperty]
        public string Account { get; set; }        
        
        /// <summary>
        /// Whether or not Turbine Chat (Allegiance chat) enabled.
        /// </summary>
        [MessageProperty]
        public bool UseTurbineChat { get; set; }        
        
        /// <summary>
        /// Whether or not this account has purchansed ToD
        /// </summary>
        [MessageProperty]
        public bool HasThroneofDestiny { get; set; }        
        


        public LoginCharacterSetS2C() : base((MessageType)0xF658, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public LoginCharacterSetS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Status = reader.ReadUInt32();
            CharacterCount = reader.ReadUInt32();
            Set.Clear();
            for(int i = 0; i < CharacterCount; i++)
            {
                CharacterIdentity newItem = new CharacterIdentity();
                newItem.Unpack(reader);
                Set.Add(newItem);
            }
            CharacterCount2 = reader.ReadUInt32();
            Delset.Clear();
            for(int i = 0; i < CharacterCount2; i++)
            {
                CharacterIdentity newItem = new CharacterIdentity();
                newItem.Unpack(reader);
                Delset.Add(newItem);
            }
            NumAllowedCharacters = reader.ReadUInt32();
            Account = reader.ReadString16L();
            UseTurbineChat = reader.ReadBool32();
            HasThroneofDestiny = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Status);
            writer.Write(CharacterCount);
            for(int i = 0; i < CharacterCount; i++)
            {
                Set[i].Pack(writer);
            }
            writer.Write(CharacterCount2);
            for(int i = 0; i < CharacterCount2; i++)
            {
                Delset[i].Pack(writer);
            }
            writer.Write(NumAllowedCharacters);
            writer.WriteString16L(Account);
            writer.WriteBool32(UseTurbineChat);
            writer.WriteBool32(HasThroneofDestiny);

        }


    }
}
