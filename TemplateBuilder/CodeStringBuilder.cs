using System;
using System.Collections.Generic;
using System.Text;
using ACE.Network.Tools.TemplateBuilder.Extensions;

namespace ACE.Network.Tools.TemplateBuilder
{
    public class CodeStringBuilder
    {
        int indent = 3;
        StringBuilder builder = new StringBuilder();

        public CodeStringBuilder(int indent = 3)
        {
            this.indent = indent;
        }

        public override string ToString()
        {
            return builder.ToString();
        }

        public void Indent()
        {
            indent++;
        }

        public void Unindent()
        {
            indent--;
        }

        public void AppendLine(string text = "")
        {
            builder.AppendLine(indent, text);
        }

        public void AppendLine(string format, params object[] args)
        {
            builder.AppendLine(indent, format, args);
        }

        public void AppendLineRaw(string text = "")
        {
            builder.AppendLine(text);
        }

        public void AppendLineRaw(string format, params object[] args)
        {
            builder.AppendLine(format, args);
        }

        public void AppendIndent()
        {
            builder.Append(Util.MakeIndention(indent));
        }

        public void Append(string text)
        {
            builder.Append(text);
        }

        public void Append(string format, params object[] args)
        {
            builder.AppendFormat(format, args);
        }

        public void OpenBlock()
        {
            builder.AppendLine(indent, "{");
            indent++;
        }

        public void CloseBlock()
        {
            indent--;
            builder.AppendLine(indent, "}");
        }

        public void AppendSummary(string text)
        {
            AppendLine("/// <summary>");
            AppendLine("/// {0}", text);
            AppendLine("/// </summary>");
        }

        public void AppendReadOnlyGenericProperty(string type, string genericType, string name)
        {
            if (!String.IsNullOrWhiteSpace(genericType))
                AppendReadOnlyProperty(String.Format("{0}<{1}>", type, genericType), name);
            else
                AppendReadOnlyProperty(type, name);
        }

        public void AppendReadOnlyKeyValueProperty(string type, string genericKey, string genericValue, string name)
        {
            if (!String.IsNullOrWhiteSpace(genericKey) && !String.IsNullOrWhiteSpace(genericValue))
                AppendReadOnlyProperty(String.Format("{0}<{1},{2}>", type, genericKey, genericValue), name);
            else
                AppendReadOnlyProperty(type, name);
        }

        public void AppendReadOnlyGenericProperty(string type, string genericType, string name, string readFunc, string writeFunc)
        {
            if (!String.IsNullOrWhiteSpace(genericType))
                AppendReadOnlyProperty(String.Format("{0}<{1}>", type, genericType), name, String.Format("{0}, {1}", readFunc, writeFunc));
            else
                AppendReadOnlyProperty(type, name);
        }

        public void AppendReadOnlyKeyValueProperty(string type, string genericKey, string genericValue, string name, string readFunc, string writeFunc)
        {
            if (!String.IsNullOrWhiteSpace(genericKey) && !String.IsNullOrWhiteSpace(genericValue))
                AppendReadOnlyProperty(String.Format("{0}<{1},{2}>", type, genericKey, genericValue), name, String.Format("{0}, {1}", readFunc, writeFunc));
            else
                AppendReadOnlyProperty(type, name);
        }

        public void AppendReadOnlyProperty(string type, string name, string props = "")
        {
            AppendLine("[MessageProperty]");
            AppendLine("public {0} {1} {{ get; }} = new {0}({2});", type, name, props);
            AppendLine();
        }

        public void AppendReadWriteProperty(string type, string name, string value = "")
        {
            AppendLine("[MessageProperty]");
            Append(Util.MakeIndention(indent));
            Append("public {0} {1} {{ get; set; }}", type, name);
            if (!String.IsNullOrWhiteSpace(value))
                Append(" = {0};", value);
            AppendLine();
            AppendLine();
        }

        public void AppendVariable(string type, string name, string assignment = "")
        {
            string rtn = String.Format("{0} {1}", type, name);
            if (!String.IsNullOrEmpty(assignment))
            {
                rtn += " = " + assignment;
            }
            AppendLine(rtn + ";");
        }
    }
}
