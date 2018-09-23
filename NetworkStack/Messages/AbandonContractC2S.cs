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
    /// Abandons a contract
    /// </summary>
    public class AbandonContractC2S : OrderedMessage
    {
        /// <summary>
        /// ID of contact being abandoned
        /// </summary>
        [MessageProperty]
        public uint ContractID { get; set; }        
        


        public AbandonContractC2S() : base((MessageType)0x0316, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public AbandonContractC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ContractID = reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ContractID);

        }


    }
}
