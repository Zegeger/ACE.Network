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
    /// Changes an account squelch
    /// </summary>
    public class ModifyCharacterSquelchC2S : OrderedMessage
    {
        /// <summary>
        /// 0 = unsquelch, 1 = squelch
        /// </summary>
        [MessageProperty]
        public bool Add { get; set; }        
        
        /// <summary>
        /// The character id who's acount should be squelched
        /// </summary>
        [MessageProperty]
        public uint CharacterID { get; set; }        
        
        /// <summary>
        /// The character's name who's acount should be squelched
        /// </summary>
        [MessageProperty]
        public string CharacterName { get; set; }        
        
        /// <summary>
        /// The message type to squelch or unsquelch
        /// </summary>
        [MessageProperty]
        public ChatMessageType MsgType { get; set; }        
        


        public ModifyCharacterSquelchC2S() : base((MessageType)0x0058, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ModifyCharacterSquelchC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Add = reader.ReadBool32();
            CharacterID = reader.ReadUInt32();
            CharacterName = reader.ReadString16L();
            MsgType = (ChatMessageType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(Add);
            writer.Write(CharacterID);
            writer.WriteString16L(CharacterName);
            writer.Write((uint)MsgType);

        }


    }
}
