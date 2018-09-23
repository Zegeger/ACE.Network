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
    /// ChannelIndex: Provides list of channels available to the player, I assume in response to a command
    /// </summary>
    public class ChannelIndexS2C : OrderedMessage
    {
        [MessageProperty]
        public PackableList<string> Channels { get; } = new PackableList<string>(ReadChannels, WriteChannels);
        


        public ChannelIndexS2C() : base((MessageType)0x0149, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ChannelIndexS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Channels.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Channels.Pack(writer);

        }

        static string ReadChannels(BinaryReader reader)
        {
            var item = reader.ReadString16L();
            return item;
        }
        
        static void WriteChannels(BinaryWriter writer, string item)
        {
            writer.WriteString16L(item);
        }
        

    }
}
