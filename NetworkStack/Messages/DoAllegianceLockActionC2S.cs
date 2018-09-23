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
    /// Perform the allegiance lock action
    /// </summary>
    public class DoAllegianceLockActionC2S : OrderedMessage
    {
        /// <summary>
        /// Allegiance housing action to take
        /// </summary>
        [MessageProperty]
        public AllegianceLockAction Action { get; set; }        
        


        public DoAllegianceLockActionC2S() : base((MessageType)0x003F, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public DoAllegianceLockActionC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Action = (AllegianceLockAction)reader.ReadUInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write((uint)Action);

        }


    }
}
