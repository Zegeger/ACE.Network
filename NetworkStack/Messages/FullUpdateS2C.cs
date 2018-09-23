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
    /// Create or join a fellowship
    /// </summary>
    public class FullUpdateS2C : OrderedMessage
    {
        /// <summary>
        /// Full set of fellowship information
        /// </summary>
        [MessageProperty]
        public Fellowship Fellowship { get; } = new Fellowship();
        


        public FullUpdateS2C() : base((MessageType)0x02BE, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public FullUpdateS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Fellowship.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Fellowship.Pack(writer);

        }


    }
}
