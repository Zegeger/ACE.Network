using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using ACE.Network.Tools.TemplateBuilder.Extensions;

namespace ACE.Network.Tools.TemplateBuilder
{
    class MessageInstance : PackableClassInstanceBase
    {
        string outputPath;
        string content;
        string type;
        string category;
        string direction;
        string ordered;
        string queue;
        XElement baseNode;

        public MessageInstance(string OutputPath, string TemplateContent, XElement node)
        {
            outputPath = OutputPath;
            content = TemplateContent;
            baseNode = node;

            type = node.GetAttribute("type");
            baseName = node.GetAttribute("name");
            category = node.GetAttribute("category");

            direction = node.GetAttribute("direction");
            ordered = node.GetAttribute("ordered");
            queue = node.GetAttribute("queue");

            // Provide Type Summary if present
            content = node.BuildSummaryFrom("text", content, "//MessageSummary\r\n", 1);

            baseName = baseName + direction;

            // Set Type name
            content = content.Replace("MessageName", baseName);

            content = content.Replace("MessageBaseClass", ordered.ToLower() == "true" ? "OrderedMessage" : "Message");

            string baseParameters = "(MessageType)" + type;
            baseParameters += ", " + (direction.ToUpper() == "S2C" ? "MessageDirection.ServerToClient" : "MessageDirection.ClientToServer");
            baseParameters += ", " + "(Queues)" + GetQueue(queue);

            content = content.Replace("BaseParameters", baseParameters);

            ProcessChildElements(node);

            // Insert properties
            content = content.Replace("//PropertyList", properties.ToString());

            // Create Unpack
            content = content.Replace("//UnpackList", unpack.ToString());

            // Create Pack
            content = content.Replace("//PackList", pack.ToString());

            // Functions for Collections
            content = content.Replace("//CollectionFunctions", collectionFunctions.ToString());

            MessageFactoryBuilder.AddName(type, baseName, direction);
        }

        private string GetQueue(string queue)
        {
            var queues = (EnumInfo)TypeTable.GetType("Queues");
            return queues.ValueMap[queue];
        }

        public void WriteContent()
        {
            string outputFile = Path.Combine(outputPath, baseName + ".cs");
            File.WriteAllText(outputFile, content);
        }
    }
}
