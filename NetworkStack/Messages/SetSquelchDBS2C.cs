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
    /// Squelch and Filter List
    /// </summary>
    public class SetSquelchDBS2C : OrderedMessage
    {
        /// <summary>
        /// The set of squelch information for the user
        /// </summary>
        [MessageProperty]
        public SquelchDB SquelchDB { get; } = new SquelchDB();
        


        public SetSquelchDBS2C() : base((MessageType)0x01F4, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public SetSquelchDBS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            SquelchDB.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            SquelchDB.Pack(writer);

        }


    }
}
