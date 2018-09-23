using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network.Tools.TemplateBuilder
{
    public class EnumInfo : TypeInfo
    {
        public Dictionary<string, string> ValueMap { get; } = new Dictionary<string, string>();

        public EnumInfo(string name, string parent) : base(name)
        {
            Parent = parent;
            IsEnum = true;
        }
    }
}
