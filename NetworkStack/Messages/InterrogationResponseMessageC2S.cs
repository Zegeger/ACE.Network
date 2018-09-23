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
    /// TODO
    /// </summary>
    public class InterrogationResponseMessageC2S : Message
    {
        [MessageProperty]
        public uint ClientLanguage { get; set; }        
        
        [MessageProperty]
        public uint Count { get; set; }        
        
        [MessageProperty]
        public List<long> Files { get; } = new List<long>();
        


        public InterrogationResponseMessageC2S() : base((MessageType)0xF7E6, MessageDirection.ClientToServer, (Queues)0x00000005)
        { }

        public InterrogationResponseMessageC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            ClientLanguage = reader.ReadUInt32();
            Count = reader.ReadUInt32();
            Files.Clear();
            for(int i = 0; i < Count; i++)
            {
                Files.Add(reader.ReadInt64());
            }

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.Write(ClientLanguage);
            writer.Write(Count);
            for(int i = 0; i < Count; i++)
            {
                writer.Write(Files[i]);
            }

        }


    }
}
