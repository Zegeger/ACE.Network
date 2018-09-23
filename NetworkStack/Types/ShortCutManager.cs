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
    /// Set of shortcuts
    /// </summary>
    public class ShortCutManager : IPackable
    {
        /// <summary>
        /// List of short cuts.
        /// </summary>
        [MessageProperty]
        public PackableList<ShortCutData> Shortcuts { get; } = new PackableList<ShortCutData>(ReadShortcuts, WriteShortcuts);
        


        public void Unpack(BinaryReader reader)
        {
            Shortcuts.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Shortcuts.Pack(writer);

        }

        static ShortCutData ReadShortcuts(BinaryReader reader)
        {
            var item = new ShortCutData();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteShortcuts(BinaryWriter writer, ShortCutData item)
        {
            item.Pack(writer);
        }
        

    }
}
