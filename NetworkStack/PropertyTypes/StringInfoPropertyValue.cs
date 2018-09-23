using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// A String property value, which can be either embedded or from a file source
    /// </summary>
    public class StringInfoPropertyValue : PropertyValue
    {
        public StringInfoType Type { get; set; } = StringInfoType.Embedded;
        public uint StringId { get; set; }
        public uint FileId { get; set; }
        public string Value { get; set; }
        public bool HasSupplementalStrings { get; set; } = true;
        public string StrToken { get; set; }
        public string StrEnglish { get; set; }
        public string StrComment { get; set; }

        override public void Pack(BinaryWriter writer)
        {
            writer.Write((byte)Type);
            if(Type == StringInfoType.FileSource)
            {
                writer.Write(StringId);
                writer.Write(FileId);
            }
            else if(Type == StringInfoType.Embedded)
            {
                writer.WriteWString(Value);
            }
            if(HasSupplementalStrings)
            {
                writer.WriteWString(StrToken);
                writer.WriteWString(StrEnglish);
                writer.WriteWString(StrComment);
            }
            // Hashtable, but just sending as empty.
            writer.Write((byte)1);
            writer.Write((byte)0);
        }

        override public void Unpack(BinaryReader reader)
        {
            Type = (StringInfoType)reader.ReadByte();
            if(Type == StringInfoType.FileSource)
            {
                StringId = reader.ReadUInt32();
                FileId = reader.ReadUInt32();
            }
            else if(Type == StringInfoType.Embedded)
            {
                Value = reader.ReadWString();
            }
            HasSupplementalStrings = reader.ReadBoolean();
            if(HasSupplementalStrings)
            {
                StrToken = reader.ReadWString();
                StrEnglish = reader.ReadWString();
                StrComment = reader.ReadWString();
            }
            reader.ReadByte();
            var count = reader.ReadByte();
            if (count > 0)
                throw new Exception("Non-Zero hashtable count, logic should be reevaluated");
        }
    }
}
