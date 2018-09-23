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
    /// List of spells in spell tab
    /// </summary>
    public class SpellTab : IPackable
    {
        /// <summary>
        /// List of spells on tab.
        /// </summary>
        [MessageProperty]
        public PackableList<LayeredSpellID> Spells { get; } = new PackableList<LayeredSpellID>(ReadSpells, WriteSpells);
        


        public void Unpack(BinaryReader reader)
        {
            Spells.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Spells.Pack(writer);

        }

        static LayeredSpellID ReadSpells(BinaryReader reader)
        {
            var item = new LayeredSpellID();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteSpells(BinaryWriter writer, LayeredSpellID item)
        {
            item.Pack(writer);
        }
        

    }
}
