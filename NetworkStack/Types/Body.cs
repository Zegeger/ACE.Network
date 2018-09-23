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
    /// Contains body part table
    /// </summary>
    public class Body : IPackable
    {
        [MessageProperty]
        public PackableHashTable<uint,BodyPart> BodyPartTable { get; } = new PackableHashTable<uint,BodyPart>(ReadBodyPartTable, WriteBodyPartTable);
        


        public void Unpack(BinaryReader reader)
        {
            BodyPartTable.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            BodyPartTable.Pack(writer);

        }

        static KeyValuePair<uint, BodyPart> ReadBodyPartTable(BinaryReader reader)
        {
            var key = reader.ReadUInt32();
            var val = new BodyPart();
            val.Unpack(reader);
            return new KeyValuePair<uint, BodyPart>(key, val);
        }
        
        static void WriteBodyPartTable(BinaryWriter writer, KeyValuePair<uint, BodyPart> pair)
        {
            writer.Write(pair.Key);
            pair.Value.Pack(writer);
        }
        

    }
}
