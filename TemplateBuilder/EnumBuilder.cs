using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Text;
using ACE.Network.Tools.TemplateBuilder.Extensions;

namespace ACE.Network.Tools.TemplateBuilder
{
    public class EnumBuilder : Builder
    {
        const string templateFile = "Templates/Enums.tcs";

        int BlankCounter = 1;

        public EnumBuilder(string OutputPath) : base(OutputPath, "Enums", templateFile)
        {
        }

        public override void Build(XElement node)
        {
            var content = templateContent;

            var name = node.GetAttribute("name");
            Console.WriteLine("Enum " + name);
            var parent = node.GetAttribute("parent");

            EnumInfo myInfo = new EnumInfo(name, parent);

            // Provide Enum Summary if present
            content = node.BuildSummaryFrom("text", content, "//EnumSummary\r\n", 1);

            // Set Enum name
            content = content.Replace("EnumName", name);
            // Set Enum data type
            content = content.Replace("Int32", parent);

            // Build Enum item list
            content = content.Replace("ItemList", BuildEnumItems(node, myInfo));

            TypeTable.AddType(myInfo);

            string outputFile = Path.Combine(outputPath, name + ".cs");
            File.WriteAllText(outputFile, content);
        }

        string BuildEnumItems(XElement node, EnumInfo myInfo)
        {
            CodeStringBuilder returnText = new CodeStringBuilder(2);
            foreach (var item in node.Elements())
            {
                if (item.Name == "value" || item.Name == "mask")
                {
                    BuildEnumItem(item, returnText, myInfo);
                }
            }
            return returnText.ToString().RemoveEndingComma();
        }

        void BuildEnumItem(XElement node, CodeStringBuilder returnText, EnumInfo myInfo)
        {
            string itemValue = node.GetAttribute("value");
            string itemName = node.GetAttribute("name");
            if(String.IsNullOrWhiteSpace(itemName))
            {
                itemName = "Unknown" + BlankCounter++;
            }
            myInfo.ValueMap.Add(itemName, itemValue);

            var itemText = node.Attribute("text");
            if (itemText != null && itemText.IsValid())
            {
                returnText.AppendLine();
                returnText.AppendSummary(itemText.Value);
            }
            returnText.AppendLine("{0} = {1},", itemName, itemValue);
        }
    }
}
