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
    /// Display an allegiance login/logout message in the chat window.
    /// </summary>
    public class AllegianceLoginNotificationEventS2C : OrderedMessage
    {
        /// <summary>
        /// the object ID of the player logging in or out
        /// </summary>
        [MessageProperty]
        public uint Member { get; set; }        
        
        /// <summary>
        /// 0=logout, 1=login
        /// </summary>
        [MessageProperty]
        public bool NowLoggedIn { get; set; }        
        


        public AllegianceLoginNotificationEventS2C() : base((MessageType)0x027A, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public AllegianceLoginNotificationEventS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Member = reader.ReadUInt32();
            NowLoggedIn = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Member);
            writer.WriteBool32(NowLoggedIn);

        }


    }
}
