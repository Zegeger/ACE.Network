using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network.Tools.TemplateBuilder
{
    static class Util
    {
        public static int GetHexLength(string type)
        {
            switch (type)
            {
                case "byte":
                case "sbyte":
                    return 2;
                case "short":
                case "ushort":
                    return 4;
                case "int":
                case "uint":
                    return 8;
                case "long":
                case "ulong":
                    return 16;
                default:
                    throw new ArgumentException("Not an integral type: " + type, "type");
                }
        }

        public static string MakeSummary(string text, int indention = 2)
        {
            string content = "/// <summary>\r\n/// Content\r\n/// </summary>\r\n";
            content = content.Replace("///", MakeIndention(indention) + "///");
            content = content.Replace("Content", text);
            return content;
        }

        public static string MakeIndention(int indention)
        {
            return new string(' ', indention * 4);
        }

        public static string CreateReaderString(TypeInfo type)
        {
            return String.Format("reader.{0}()", type.Reader);
        }

        public static string CreateReaderString(EnumInfo enumInfo)
        {
            TypeInfo parentType = TypeTable.GetType(enumInfo.Parent);
            return String.Format("({1})reader.{0}()", parentType.Reader, enumInfo.Name);
        }

        public static string CreateReaderString(EnumInfo enumInfo, TypeInfo type)
        {
            return String.Format("({1})reader.{0}()", type.Reader, enumInfo.Name);
        }

        public static string CreateWriterString(TypeInfo type, string variable, bool cast = false)
        {
            string writer = "Write";
            if (!String.IsNullOrEmpty(type.Writer))
                writer = type.Writer;
            if(!cast)
                return String.Format("writer.{1}({0})", variable, writer);
            else
                return String.Format("writer.{1}(({2}){0})", variable, writer, type.Name);
        }

        public static string CreateWriterString(EnumInfo enumInfo, string variable)
        {
            TypeInfo parentType = TypeTable.GetType(enumInfo.Parent);
            string writer = "Write";
            if (!String.IsNullOrEmpty(parentType.Writer))
                writer = parentType.Writer;
            return String.Format("writer.{1}(({2}){0})", variable, writer, parentType.Name);
        }

        public static string CreateStaticWriterString(TypeInfo type, string staticValue)
        {
            if(type.UsableType != "string")
                return CreateWriterString(type, String.Format("({0}){1}", type.UsableType, staticValue));
            else
                return CreateWriterString(type, staticValue);
        }
    }
}
