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
    /// Contains information related to your spellbook
    /// </summary>
    public class SpellBook : IPackable
    {
        /// <summary>
        /// Spells in the characters spellbook
        /// </summary>
        [MessageProperty]
        public PackableHashTable<LayeredSpellID,SpellBookPage> Book { get; } = new PackableHashTable<LayeredSpellID,SpellBookPage>(ReadBook, WriteBook);
        


        public void Unpack(BinaryReader reader)
        {
            Book.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Book.Pack(writer);

        }

        static KeyValuePair<LayeredSpellID, SpellBookPage> ReadBook(BinaryReader reader)
        {
            var key = new LayeredSpellID();
            key.Unpack(reader);
            var val = new SpellBookPage();
            val.Unpack(reader);
            return new KeyValuePair<LayeredSpellID, SpellBookPage>(key, val);
        }
        
        static void WriteBook(BinaryWriter writer, KeyValuePair<LayeredSpellID, SpellBookPage> pair)
        {
            pair.Key.Pack(writer);
            pair.Value.Pack(writer);
        }
        

    }
}
