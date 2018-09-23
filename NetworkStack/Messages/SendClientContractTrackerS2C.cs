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
    /// Updates a contract data
    /// </summary>
    public class SendClientContractTrackerS2C : OrderedMessage
    {
        [MessageProperty]
        public ContractTracker ContractTracker { get; } = new ContractTracker();
        
        [MessageProperty]
        public bool DeleteContract { get; set; }        
        
        [MessageProperty]
        public bool SetAsDisplayContract { get; set; }        
        


        public SendClientContractTrackerS2C() : base((MessageType)0x0315, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public SendClientContractTrackerS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ContractTracker.Unpack(reader);
            DeleteContract = reader.ReadBool32();
            SetAsDisplayContract = reader.ReadBool32();

        }

        public override void Pack(BinaryWriter writer)
        {
            ContractTracker.Pack(writer);
            writer.WriteBool32(DeleteContract);
            writer.WriteBool32(SetAsDisplayContract);

        }


    }
}
