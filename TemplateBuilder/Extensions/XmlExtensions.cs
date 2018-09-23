using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ACE.Network.Tools.TemplateBuilder.Extensions
{
    static class XmlExtensions
    {
        public static bool IsValid(this XAttribute attrib)
        {
            return !String.IsNullOrWhiteSpace(attrib.Value);
        }

        public static bool HasAttribute(this XElement node, string attribute)
        {
            var attrib = node.Attribute(attribute);
            return (attrib != null && attrib.IsValid());
        }

        public static bool CheckAttribute(this XElement node, string attributeName, string checkValue)
        {
            var result = node.Attribute(attributeName);
            if (result != null)
            {
                return result.Value == checkValue;
            }
            return false;
        }

        public static string GetAttribute(this XElement node, string attributeName, bool require = true)
        {
            var result = node.Attribute(attributeName);
            if (require && (result == null /*|| !result.IsValid()*/))
                throw new FormatException("Missing attribute " + attributeName + " in XML node " + node.Name);
            if (result != null)
                return result.Value;
            return "";
        }

        public static bool TryGetAttribute(this XElement node, string attributeName, out string value)
        {
            var result = node.Attribute(attributeName);
            if (result == null)
            {
                value = null;
                return false;
            }
            value = result.Value;
            return true;
        }

        public static string BuildSummaryFrom(this XElement node, string attribute, int indention = 1)
        {
            var attrib = node.Attribute(attribute);
            if (attrib != null && attrib.IsValid())
            {
                return Util.MakeSummary(attrib.Value, indention);
            }
            return null;
        }

        public static string BuildSummaryFrom(this XElement node, string attribute, string content, string placeholder, int indention = 1)
        {
            var summary = BuildSummaryFrom(node, attribute, indention);
            if (summary != null)
            {
                return content.Replace(placeholder, summary);
            }
            else
            {
                return content.Replace(placeholder, "");
            }
        }
    }
}
