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
    public static class MessageFactoryBuilder
    {
        static string templateFile = "Templates/MessageFactory.tcs";

        static CodeStringBuilder ListAdds = new CodeStringBuilder(3);

        static string outputPath;
        static string templateContent;

        public static void Initialize(string OutputPath)
        {
            outputPath = Path.Combine(OutputPath, "Messages");
            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);
            templateContent = File.ReadAllText(templateFile);
        }

        public static void AddName(string type, string name, string direction)
        {
            if(direction == "C2S")
                ListAdds.AppendLine("C2SMessageTable.Add({0}, (reader) => new {1}(reader));", type, name);
            else if(direction == "S2C")
                ListAdds.AppendLine("S2CMessageTable.Add({0}, (reader) => new {1}(reader));", type, name);
        }

        public static void Build()
        {
            var content = templateContent;
            content = content.Replace("//TableAdds", ListAdds.ToString());
            string outputFile = Path.Combine(outputPath, "MessageFactory.cs");
            File.WriteAllText(outputFile, content);
        }
    }
}
