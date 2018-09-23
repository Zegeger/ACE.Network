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
    /// Sets the player visual desc, TODO confirm this
    /// </summary>
    public class SetPlayerVisualDescS2C : Message
    {
        /// <summary>
        /// Set of visual description information for the player
        /// </summary>
        [MessageProperty]
        public ObjDesc ObjDesc { get; } = new ObjDesc();
        


        public SetPlayerVisualDescS2C() : base((MessageType)0xF630, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public SetPlayerVisualDescS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ObjDesc.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            ObjDesc.Pack(writer);

        }


    }
}
