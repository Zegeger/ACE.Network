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
    /// Sends all contract data
    /// </summary>
    public class SendClientContractTrackerTableS2C : OrderedMessage
    {
        [MessageProperty]
        public ContractTrackerTable ContractTrackerTable { get; } = new ContractTrackerTable();
        


        public SendClientContractTrackerTableS2C() : base((MessageType)0x0314, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public SendClientContractTrackerTableS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ContractTrackerTable.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            ContractTrackerTable.Pack(writer);

        }


    }
}
