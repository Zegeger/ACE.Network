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
    public class MessageBuilder : Builder
    {
        const string templateFile = "Templates/Messages.tcs";
        

        public MessageBuilder(string BasePath) : base(BasePath, "Messages", templateFile)
        {
            
        }

        public override void Build(XElement node)
        {
            foreach (XElement e in node.Elements())
            {
                if (e.Name == "message")
                {
                    var name = e.GetAttribute("name");
                    Console.WriteLine("Message " + name);

                    MessageInstance mi = new MessageInstance(outputPath, templateContent, e);
                    mi.WriteContent();
                }
            }
        }
    }
}
