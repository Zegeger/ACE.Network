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
    public class EmoteSetList : IPackable
    {
        /// <summary>
        /// List of emote sets
        /// </summary>
        [MessageProperty]
        public PackableList<EmoteSet> SetList { get; } = new PackableList<EmoteSet>(ReadSetList, WriteSetList);
        


        public void Unpack(BinaryReader reader)
        {
            SetList.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            SetList.Pack(writer);

        }

        static EmoteSet ReadSetList(BinaryReader reader)
        {
            var item = new EmoteSet();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteSetList(BinaryWriter writer, EmoteSet item)
        {
            item.Pack(writer);
        }
        

    }
}
