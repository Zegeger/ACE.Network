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
    public class GeneratorTable : IPackable
    {
        /// <summary>
        /// List of generator profiles
        /// </summary>
        [MessageProperty]
        public PackableList<GeneratorProfile> Generators { get; } = new PackableList<GeneratorProfile>(ReadGenerators, WriteGenerators);
        


        public void Unpack(BinaryReader reader)
        {
            Generators.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Generators.Pack(writer);

        }

        static GeneratorProfile ReadGenerators(BinaryReader reader)
        {
            var item = new GeneratorProfile();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteGenerators(BinaryWriter writer, GeneratorProfile item)
        {
            item.Pack(writer);
        }
        

    }
}
