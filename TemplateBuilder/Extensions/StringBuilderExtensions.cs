using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network.Tools.TemplateBuilder.Extensions
{
    static class StringBuilderExtensions
    {
        public static void AppendLine(this StringBuilder builder, string format, params object[] args)
        {
            builder.AppendLine(String.Format(format, args));
        }

        public static void AppendLine(this StringBuilder builder, int indention, string format, params object[] args)
        {
            builder.Append(Util.MakeIndention(indention));
            builder.AppendLine(String.Format(format, args));
        }

        public static void AppendLine(this StringBuilder builder, int indention, string text)
        {
            builder.Append(Util.MakeIndention(indention));
            builder.AppendLine(text);
        }

        public static void Append(this StringBuilder builder, int indention, string text)
        {
            builder.Append(Util.MakeIndention(indention));
            builder.Append(text);
        }

        public static void Append(this StringBuilder builder, int indention, string format, params object[] args)
        {
            builder.Append(Util.MakeIndention(indention));
            builder.Append(String.Format(format, args));
        }
    }
}
