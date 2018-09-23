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
    /// Admin Returns a plugin list response
    /// </summary>
    public class QueryPluginListResponseC2S : OrderedMessage
    {
        [MessageProperty]
        public uint Context { get; set; }        
        
        [MessageProperty]
        public string PluginList { get; set; }        
        


        public QueryPluginListResponseC2S() : base((MessageType)0x02AF, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public QueryPluginListResponseC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Context = reader.ReadUInt32();
            PluginList = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Context);
            writer.WriteString16L(PluginList);

        }


    }
}
