////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Types;
using ACE.Network.Extensions;

namespace ACE.Network.Messages
{
    /// <summary>
    /// Completes the barber interaction
    /// </summary>
    public class FinishBarberC2S : OrderedMessage
    {
        [MessageProperty]
        public uint BasePalette { get; set; }        
        
        [MessageProperty]
        public uint HeadObject { get; set; }        
        
        [MessageProperty]
        public uint HeadTexture { get; set; }        
        
        [MessageProperty]
        public uint DefaultHeadTexture { get; set; }        
        
        [MessageProperty]
        public uint EyesTexture { get; set; }        
        
        [MessageProperty]
        public uint DefaultEyesTexture { get; set; }        
        
        [MessageProperty]
        public uint NoseTexture { get; set; }        
        
        [MessageProperty]
        public uint DefaultNoseTexture { get; set; }        
        
        [MessageProperty]
        public uint MouthTexture { get; set; }        
        
        [MessageProperty]
        public uint DefaultMouthTexture { get; set; }        
        
        [MessageProperty]
        public uint SkinPalette { get; set; }        
        
        [MessageProperty]
        public uint HairPalette { get; set; }        
        
        [MessageProperty]
        public uint EyesPalette { get; set; }        
        
        [MessageProperty]
        public uint SetupID { get; set; }        
        
        /// <summary>
        /// Specifies the toggle option for some races, such as floating empyrean or flaming head on undead
        /// </summary>
        [MessageProperty]
        public int Option1 { get; set; }        
        
        /// <summary>
        /// Seems to be unused
        /// </summary>
        [MessageProperty]
        public int Option2 { get; set; }        
        


        public FinishBarberC2S() : base((MessageType)0x0311, MessageDirection.ClientToServer, (Queues)0x00000003)
        { }

        public FinishBarberC2S(BinaryReader reader) : this()
        {
            Unpack(reader);
        }
        
        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);
            BasePalette = reader.ReadUIntCompressed16();
            HeadObject = reader.ReadUIntCompressed16();
            HeadTexture = reader.ReadUIntCompressed16();
            DefaultHeadTexture = reader.ReadUIntCompressed16();
            EyesTexture = reader.ReadUIntCompressed16();
            DefaultEyesTexture = reader.ReadUIntCompressed16();
            NoseTexture = reader.ReadUIntCompressed16();
            DefaultNoseTexture = reader.ReadUIntCompressed16();
            MouthTexture = reader.ReadUIntCompressed16();
            DefaultMouthTexture = reader.ReadUIntCompressed16();
            SkinPalette = reader.ReadUIntCompressed16();
            HairPalette = reader.ReadUIntCompressed16();
            EyesPalette = reader.ReadUIntCompressed16();
            SetupID = reader.ReadUIntCompressed16();
            Option1 = reader.ReadInt32();
            Option2 = reader.ReadInt32();

        }

        public override void Pack(BinaryWriter writer)
        {
            writer.WriteUIntCompressed16(BasePalette);
            writer.WriteUIntCompressed16(HeadObject);
            writer.WriteUIntCompressed16(HeadTexture);
            writer.WriteUIntCompressed16(DefaultHeadTexture);
            writer.WriteUIntCompressed16(EyesTexture);
            writer.WriteUIntCompressed16(DefaultEyesTexture);
            writer.WriteUIntCompressed16(NoseTexture);
            writer.WriteUIntCompressed16(DefaultNoseTexture);
            writer.WriteUIntCompressed16(MouthTexture);
            writer.WriteUIntCompressed16(DefaultMouthTexture);
            writer.WriteUIntCompressed16(SkinPalette);
            writer.WriteUIntCompressed16(HairPalette);
            writer.WriteUIntCompressed16(EyesPalette);
            writer.WriteUIntCompressed16(SetupID);
            writer.Write(Option1);
            writer.Write(Option2);

        }


    }
}
