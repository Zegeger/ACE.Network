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
    /// Makes a chess move
    /// </summary>
    public class MoveC2S : OrderedMessage
    {
        /// <summary>
        /// Current x location of piece being moved
        /// </summary>
        [MessageProperty]
        public int XFrom { get; set; }        
        
        /// <summary>
        /// Current y location of piece being moved
        /// </summary>
        [MessageProperty]
        public int YFrom { get; set; }        
        
        /// <summary>
        /// Destination x location of piece being moved
        /// </summary>
        [MessageProperty]
        public int XTo { get; set; }        
        
        /// <summary>
        /// Destination y location of piece being moved
        /// </summary>
        [MessageProperty]
        public int YTo { get; set; }        
        


        public MoveC2S() : base((MessageType)0x026B, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public MoveC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            XFrom = reader.ReadInt32();
            YFrom = reader.ReadInt32();
            XTo = reader.ReadInt32();
            YTo = reader.ReadInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(XFrom);
            writer.Write(YFrom);
            writer.Write(XTo);
            writer.Write(YTo);

        }


    }
}
