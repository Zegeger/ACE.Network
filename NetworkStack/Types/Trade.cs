////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// Information related to a secure trade.
    /// </summary>
    public class Trade : IPackable
    {
        /// <summary>
        /// ID of other participant in the trade
        /// </summary>
        [MessageProperty]
        public uint Partner { get; set; }        
        
        /// <summary>
        /// Some kind of sequence
        /// </summary>
        [MessageProperty]
        public ulong Stamp { get; set; }        
        
        /// <summary>
        /// Some kind of status for the trade TODO
        /// </summary>
        [MessageProperty]
        public uint Status { get; set; }        
        
        /// <summary>
        /// ID of person who initiated the trade
        /// </summary>
        [MessageProperty]
        public uint Initiator { get; set; }        
        
        /// <summary>
        /// Whether you accepted this trade
        /// </summary>
        [MessageProperty]
        public bool Accepted { get; set; }        
        
        /// <summary>
        /// Whether the partner accepted this trade
        /// </summary>
        [MessageProperty]
        public bool PAccepted { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Partner = reader.ReadUInt32();
            Stamp = reader.ReadUInt64();
            Status = reader.ReadUInt32();
            Initiator = reader.ReadUInt32();
            Accepted = reader.ReadBool32();
            PAccepted = reader.ReadBool32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Partner);
            writer.Write(Stamp);
            writer.Write(Status);
            writer.Write(Initiator);
            writer.WriteBool32(Accepted);
            writer.WriteBool32(PAccepted);

        }


    }
}
