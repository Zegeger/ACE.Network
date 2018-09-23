using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using ACE.Network.Tools.TemplateBuilder.Extensions;

namespace ACE.Network.Tools.TemplateBuilder
{
    class TypeInstance : PackableClassInstanceBase
    {
        string outputPath;
        string content;
        XElement baseNode;

        public TypeInstance(string OutputPath, string TemplateContent, XElement node)
        {
            outputPath = OutputPath;
            content = TemplateContent;
            baseNode = node;

            baseName = node.GetAttribute("name");

            // Provide Type Summary if present
            content = node.BuildSummaryFrom("text", content, "//TypeSummary\r\n", 1);

            // Set Type name
            content = content.Replace("TypeName", baseName);

            ProcessChildElements(node);

            // Insert properties
            content = content.Replace("//PropertyList", properties.ToString());

            // Create Unpack
            content = content.Replace("//UnpackList", unpack.ToString());

            // Create Pack
            content = content.Replace("//PackList", pack.ToString());

            // Functions for Collections
            content = content.Replace("//CollectionFunctions", collectionFunctions.ToString());
        }

        public void WriteContent()
        {
            string outputFile = Path.Combine(outputPath, baseName + ".cs");
            File.WriteAllText(outputFile, content);
        }
    }
}
