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
using ACE.Network.Types;

namespace ACE.Network.Packets.Headers
{
    /// <summary>
    /// Passes some kind of network error, seems to pull string id from dats
    /// </summary>
    public class NetError
    {
        /// <summary>
        /// Id of string error?
        /// </summary>
        [MessageProperty]
        public uint StringID { get; set; }        
        
        /// <summary>
        /// DID?
        /// </summary>
        [MessageProperty]
        public uint TableID { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            StringID = reader.ReadUInt32();
            TableID = reader.ReadUInt32();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(StringID);
            writer.Write(TableID);

        }
    }
}
