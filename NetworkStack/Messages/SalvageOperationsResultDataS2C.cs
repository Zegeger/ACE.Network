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
    /// Salvage operation results
    /// </summary>
    public class SalvageOperationsResultDataS2C : OrderedMessage
    {
        [MessageProperty]
        public SalvageOperationsResultData OperationsResultData { get; } = new SalvageOperationsResultData();
        


        public SalvageOperationsResultDataS2C() : base((MessageType)0x02B4, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public SalvageOperationsResultDataS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            OperationsResultData.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            OperationsResultData.Pack(writer);

        }


    }
}
