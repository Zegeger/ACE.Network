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
    public class TypeBuilder : Builder
    {
        public TypeBuilder(string templateFile, string BasePath, string Folder, string Namespace) : base(BasePath, Folder, templateFile)
        {
            templateContent = templateContent.Replace("NamespacePlaceholder", Namespace);
        }

        private void BuildTable(XElement parentNode)
        {
            foreach (XElement node in parentNode.Elements())
            {
                if (node.Name == "type")
                {
                    var name = node.GetAttribute("name");

                    if (TypeTable.TypeExists(name))
                        throw new Exception("Duplicated Type " + name);

                    TypeInfo newType = new TypeInfo(name);

                    if (node.HasAttribute("parent"))
                    {
                        newType.Parent = node.GetAttribute("parent");
                    }

                    if (node.HasAttribute("primitive"))
                    {
                        newType.IsPrimitive = node.GetAttribute("primitive") == "true";
                    }

                    if (node.HasAttribute("reader"))
                    {
                        newType.Reader = node.GetAttribute("reader");
                    }

                    if (node.HasAttribute("writer"))
                    {
                        newType.Writer = node.GetAttribute("writer");
                    }

                    if (node.HasAttribute("noTemplate"))
                    {
                        newType.NoTemplate = node.GetAttribute("noTemplate") == "true";
                    }

                    if (node.HasAttribute("integer"))
                    {
                        newType.IsIntegerType = node.GetAttribute("integer") == "true";
                    }

                    if (node.HasAttribute("signed"))
                    {
                        newType.IsSignedType = node.GetAttribute("signed") == "true";
                    }

                    if (node.HasAttribute("baseType"))
                    {
                        newType.BaseType = node.GetAttribute("baseType");
                    }

                    TypeTable.AddType(newType);
                }
            }
        }

        public override void Build(XElement parentNode)
        {
            BuildTable(parentNode);
            foreach (XElement node in parentNode.Elements())
            {
                if (node.Name == "type")
                {
                    var name = node.GetAttribute("name");
                    Console.WriteLine("Type " + name);

                    if (!TypeTable.TypeExists(name))
                        throw new Exception("Missing Type " + name);

                    var newType = TypeTable.GetType(name);

                    if (newType.IsPrimitive || newType.NoTemplate)
                        continue;

                    TypeInstance ti = new TypeInstance(outputPath, templateContent, node);
                    ti.WriteContent();
                }
            }
        }
    }
}
