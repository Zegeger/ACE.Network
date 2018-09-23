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
    /// Basic information for a character used at the Login screen
    /// </summary>
    public class CharacterIdentity : IPackable
    {
        /// <summary>
        /// The character ID for this entry.
        /// </summary>
        [MessageProperty]
        public uint Gid { get; set; }        
        
        /// <summary>
        /// The name of this character.
        /// </summary>
        [MessageProperty]
        public string Name { get; set; }        
        
        /// <summary>
        /// When 0, this character is not being deleted (not shown crossed out). Otherwise, it's a countdown timer in the number of seconds until the character is submitted for deletion.
        /// </summary>
        [MessageProperty]
        public uint SecondsGreyedOut { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            Gid = reader.ReadUInt32();
            Name = reader.ReadString16L();
            SecondsGreyedOut = reader.ReadUInt32();
            reader.Align();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Gid);
            writer.WriteString16L(Name);
            writer.Write(SecondsGreyedOut);
            writer.Align();

        }


    }
}
