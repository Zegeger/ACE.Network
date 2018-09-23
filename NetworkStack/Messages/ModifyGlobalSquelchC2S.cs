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
    /// Changes the global filters, /filter -type as well as /chat and /notell
    /// </summary>
    public class ModifyGlobalSquelchC2S : OrderedMessage
    {
        /// <summary>
        /// 0 = unsquelch, 1 = squelch
        /// </summary>
        [MessageProperty]
        public bool Add { get; set; }        
        
        /// <summary>
        /// The message type to squelch or unsquelch
        /// </summary>
        [MessageProperty]
        public ChatMessageType MsgType { get; set; }        
        


        public ModifyGlobalSquelchC2S() : base((MessageType)0x005B, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ModifyGlobalSquelchC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Add = reader.ReadBool32();
            MsgType = (ChatMessageType)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteBool32(Add);
            writer.Write((uint)MsgType);

        }


    }
}
