using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network.Tools.TemplateBuilder.Extensions
{
    static class StringExtensions
    {
        public static string RemoveEndingComma(this string text)
        {
            return text.TrimEnd(new char[] { ',', '\n', '\r' });
        }

        public static string Capitalize(this string input)
        {
            return Char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
