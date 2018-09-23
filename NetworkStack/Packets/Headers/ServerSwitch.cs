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
using ACE.Network.Types;

namespace ACE.Network.Packets.Headers
{
    /// <summary>
    /// Sent by the server to acknowledge the server switch
    /// </summary>
    public class ServerSwitch
    {
        /// <summary>
        /// Sequence value for the switches.
        /// </summary>
        [MessageProperty]
        public uint SeqNo { get; set; }        
        
        /// <summary>
        /// Cookie value sent in the referral.
        /// </summary>
        [MessageProperty]
        public ServerSwitchType Type { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            SeqNo = reader.ReadUInt32();
            Type = (ServerSwitchType)reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(SeqNo);
            writer.Write((uint)Type);

        }
    }
}
