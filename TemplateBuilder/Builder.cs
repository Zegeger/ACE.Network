using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace ACE.Network.Tools.TemplateBuilder
{
    public abstract class Builder
    {
        protected string outputPath;
        protected string templateContent;
        protected Builder(string BasePath, string Folder, string templateFile)
        {
            outputPath = Path.Combine(BasePath, Folder);
            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);
            templateContent = File.ReadAllText(templateFile);
        }

        public virtual void Build(XElement node)
        {

        }
    }
}
