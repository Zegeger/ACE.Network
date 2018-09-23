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
    public class GeneratorRegistry : IPackable
    {
        [MessageProperty]
        public PackableHashTable<uint,GeneratorRegistryNode> Registry { get; } = new PackableHashTable<uint,GeneratorRegistryNode>(ReadRegistry, WriteRegistry);
        


        public void Unpack(BinaryReader reader)
        {
            Registry.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Registry.Pack(writer);

        }

        static KeyValuePair<uint, GeneratorRegistryNode> ReadRegistry(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = new GeneratorRegistryNode();
            val.Unpack(reader);
            return new KeyValuePair<uint, GeneratorRegistryNode>(key, val);
        }
        
        static void WriteRegistry(BinaryWriter writer, KeyValuePair<uint, GeneratorRegistryNode> pair)
        {
            writer.Write(pair.Key);
            pair.Value.Pack(writer);
        }
        

    }
}
