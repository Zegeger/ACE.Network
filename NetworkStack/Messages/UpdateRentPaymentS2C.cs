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
    /// Update Rent Payment
    /// </summary>
    public class UpdateRentPaymentS2C : OrderedMessage
    {
        [MessageProperty]
        public PackableList<HousePayment> Rent { get; } = new PackableList<HousePayment>(ReadRent, WriteRent);
        


        public UpdateRentPaymentS2C() : base((MessageType)0x0228, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public UpdateRentPaymentS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Rent.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Rent.Pack(writer);

        }

        static HousePayment ReadRent(BinaryReader reader)
        {
            var item = new HousePayment();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteRent(BinaryWriter writer, HousePayment item)
        {
            item.Pack(writer);
        }
        

    }
}
