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
    /// Admin Returns plugin info
    /// </summary>
    public class ClientQueryPluginResponseC2S : OrderedMessage
    {
        [MessageProperty]
        public uint Context { get; set; }        
        
        [MessageProperty]
        public bool Success { get; set; }        
        
        [MessageProperty]
        public string PluginName { get; set; }        
        
        [MessageProperty]
        public string PluginAuthor { get; set; }        
        
        [MessageProperty]
        public string PluginEmail { get; set; }        
        
        [MessageProperty]
        public string PluginWebpage { get; set; }        
        


        public ClientQueryPluginResponseC2S() : base((MessageType)0x02B2, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public ClientQueryPluginResponseC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Context = reader.ReadUInt32();
            Success = reader.ReadBool32();
            PluginName = reader.ReadString16L();
            PluginAuthor = reader.ReadString16L();
            PluginEmail = reader.ReadString16L();
            PluginWebpage = reader.ReadString16L();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(Context);
            writer.WriteBool32(Success);
            writer.WriteString16L(PluginName);
            writer.WriteString16L(PluginAuthor);
            writer.WriteString16L(PluginEmail);
            writer.WriteString16L(PluginWebpage);

        }


    }
}
