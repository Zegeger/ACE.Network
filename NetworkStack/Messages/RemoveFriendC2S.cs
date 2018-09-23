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
    /// Removes a friend
    /// </summary>
    public class RemoveFriendC2S : OrderedMessage
    {
        /// <summary>
        /// The id of the friend to remove
        /// </summary>
        [MessageProperty]
        public uint FriendID { get; set; }        
        


        public RemoveFriendC2S() : base((MessageType)0x0017, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public RemoveFriendC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            FriendID = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(FriendID);

        }


    }
}
