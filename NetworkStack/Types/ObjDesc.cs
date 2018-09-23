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
    /// The ObjDesc structure defines an object's visual appearance.
    /// </summary>
    public class ObjDesc : IPackable
    {
        /// <summary>
        /// the number of palettes associated with this object
        /// </summary>
        [MessageProperty]
        public byte PaletteCount { get; set; }        
        
        /// <summary>
        /// the number of textures associated with this object
        /// </summary>
        [MessageProperty]
        public byte TextureCount { get; set; }        
        
        /// <summary>
        /// the number of models associated with this object
        /// </summary>
        [MessageProperty]
        public byte ModelCount { get; set; }        
        
        /// <summary>
        /// palette DataID (minus 0x04000000)
        /// </summary>
        [MessageProperty]
        public uint Palette { get; set; }        
        
        [MessageProperty]
        public List<Subpalette> Subpalettes { get; } = new List<Subpalette>();
        
        [MessageProperty]
        public List<TextureMapChange> TmChanges { get; } = new List<TextureMapChange>();
        
        [MessageProperty]
        public List<AnimPartChange> ApChanges { get; } = new List<AnimPartChange>();
        


        public void Unpack(BinaryReader reader)
        {
            var temp1 = reader.ReadByte(); // Unused value
#if NETWORKVALIDATION
            if(temp1 != 0x11)
            {
                throw new Exception("Recieved value different from static on ObjDesc, expected: 0x11, actual " + temp1);
            }
#endif
            PaletteCount = reader.ReadByte();
            TextureCount = reader.ReadByte();
            ModelCount = reader.ReadByte();
            if(PaletteCount > 0)
            {
                Palette = reader.ReadUIntCompressed16();
                Subpalettes.Clear();
                for(int i = 0; i < PaletteCount; i++)
                {
                    Subpalette newItem = new Subpalette();
                    newItem.Unpack(reader);
                    Subpalettes.Add(newItem);
                }
            }
            TmChanges.Clear();
            for(int i = 0; i < TextureCount; i++)
            {
                TextureMapChange newItem = new TextureMapChange();
                newItem.Unpack(reader);
                TmChanges.Add(newItem);
            }
            ApChanges.Clear();
            for(int i = 0; i < ModelCount; i++)
            {
                AnimPartChange newItem = new AnimPartChange();
                newItem.Unpack(reader);
                ApChanges.Add(newItem);
            }
            reader.Align();

        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((byte)0x11); // Unused value
            writer.Write(PaletteCount);
            writer.Write(TextureCount);
            writer.Write(ModelCount);
            if(PaletteCount > 0)
            {
                writer.WriteUIntCompressed16(Palette);
                for(int i = 0; i < PaletteCount; i++)
                {
                    Subpalettes[i].Pack(writer);
                }
            }
            for(int i = 0; i < TextureCount; i++)
            {
                TmChanges[i].Pack(writer);
            }
            for(int i = 0; i < ModelCount; i++)
            {
                ApChanges[i].Pack(writer);
            }
            writer.Align();

        }


    }
}
