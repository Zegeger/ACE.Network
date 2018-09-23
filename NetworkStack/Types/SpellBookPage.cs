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
    /// Contains information related to the spell in your spellbook
    /// </summary>
    public class SpellBookPage : IPackable
    {
        /// <summary>
        /// Final value has 2.0 subtracted if network value > 2.0.  Believe this is the charge of the spell which was unused later
        /// </summary>
        [MessageProperty]
        public float CastingLikelihood { get; set; }        
        
        /// <summary>
        /// Replaces castingLikelihood
        /// </summary>
        [MessageProperty]
        public float CastingLikelihood2 { get; set; }        
        


        public void Unpack(BinaryReader reader)
        {
            CastingLikelihood = reader.ReadSingle();
            if(CastingLikelihood < 2.0)
            {
                var temp1 = reader.ReadInt32(); // Unused value
#if NETWORKVALIDATION
                if(temp1 != 0)
                {
                    throw new Exception("Recieved value different from static on SpellBookPage, expected: 0, actual " + temp1);
                }
#endif
                CastingLikelihood2 = reader.ReadSingle();
            }

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(CastingLikelihood);
            if(CastingLikelihood < 2.0)
            {
                writer.Write((int)0); // Unused value
                writer.Write(CastingLikelihood2);
            }

        }


    }
}
