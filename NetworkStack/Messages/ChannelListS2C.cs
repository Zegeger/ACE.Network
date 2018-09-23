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
    /// ChannelList: Provides list of characters listening to a channel, I assume in response to a command
    /// </summary>
    public class ChannelListS2C : OrderedMessage
    {
        [MessageProperty]
        public PackableList<string> Characters { get; } = new PackableList<string>(ReadCharacters, WriteCharacters);
        


        public ChannelListS2C() : base((MessageType)0x0148, MessageDirection.ServerToClient, (Queues)0x00000009)
        { }

        public ChannelListS2C(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            Characters.Unpack(reader);

        }

        public override void Pack(BinaryWriter writer)
        {
            Characters.Pack(writer);

        }

        static string ReadCharacters(BinaryReader reader)
        {
            var item = reader.ReadString16L();
            return item;
        }
        
        static void WriteCharacters(BinaryWriter writer, string item)
        {
            writer.WriteString16L(item);
        }
        

    }
}
