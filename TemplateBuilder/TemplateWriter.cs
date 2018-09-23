using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace ACE.Network.Tools.TemplateBuilder
{
    public class TemplateWriter
    {
        static Version schemaVersion = new Version("2.0.0.0");
        EnumBuilder enumBuilder;
        TypeBuilder typeBuilder;
        TypeBuilder headerBuilder;
        MessageBuilder messageBuilder;

        Dictionary<string, string> cats = new Dictionary<string, string>();
        Dictionary<string, string> types = new Dictionary<string, string>();

        public TemplateWriter(string OutputPath)
        {
            if (!Directory.Exists(OutputPath))
                Directory.CreateDirectory(OutputPath);
            enumBuilder = new EnumBuilder(OutputPath);
            typeBuilder = new TypeBuilder("Templates/Types.tcs", OutputPath, "Types", "Types");
            headerBuilder = new TypeBuilder("Templates/Headers.tcs", OutputPath, "Packets\\Headers", "Packets.Headers");
            messageBuilder = new MessageBuilder(OutputPath);
            MessageFactoryBuilder.Initialize(OutputPath);
        }

        public void CreateFromXMLFile(string path)
        {
            //StreamReader reader = new StreamReader(path);
            //StreamWriter writer = new StreamWriter(Path.GetFileNameWithoutExtension(path) + "2" + Path.GetExtension(path));
            //string line = null;
            //while((line = reader.ReadLine()) != null)
            //{
            //    if(line.Contains("<message "))
            //    {
            //        var pos = line.IndexOf("type=\"");
            //        var type = line.Substring(pos + 6, 6);
            //        pos = line.IndexOf("direction=\"");
            //        line = line.Insert(pos, "name=\"" + types[type] + "\" category=\"" + cats[type] + "\" ");
            //    }
            //    writer.WriteLine(line);
            //}
            //writer.Close();
            //return;

            XDocument doc = XDocument.Load(path);

            foreach (XElement e in doc.Elements())
            {
                if (e.Name == "schema" && Version.Parse(e.Attribute("version").Value) >= schemaVersion)
                {
                    ProcessSchema(e);
                }
                else
                {
                    throw new Exception("schema missing or version below minimum required: " + schemaVersion);
                }
            }

            MessageFactoryBuilder.Build();
        }

        private void ProcessSchema(XElement node)
        {
            foreach (XElement e in node.Elements())
            {
                switch (e.Name.ToString())
                {
                    case "revision":
                        Console.WriteLine("Revision: " + e.Attribute("version").Value);
                        break;
                    case "enums":
                        ProcessEnums(e);
                        break;
                    case "types":
                        ProcessTypes(e);
                        break;
                    case "messages":
                        ProcessMessages(e);
                        break;
                    case "packets":
                        ProcessPackets(e);
                        break;
                }
            }
        }

        private void ProcessEnums(XElement node)
        {
            foreach (XElement e in node.Elements())
            {
                if (e.Name == "enum")
                {
                    enumBuilder.Build(e);
                }
            }
        }

        private void ProcessTypes(XElement node)
        {
            typeBuilder.Build(node);
        }

        private void ProcessPackets(XElement node)
        {
            foreach (XElement e in node.Elements())
            {
                if (e.Name == "headers")
                {
                    ProcessHeaders(e);
                }
            }
        }

        private void ProcessHeaders(XElement node)
        {
            headerBuilder.Build(node);
        }

        private void ProcessMessages(XElement node)
        {
            messageBuilder.Build(node);
        }
    }
}
