using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network.Tools.TemplateBuilder
{
    public class TypeInfo
    {
        public string Name { get; private set; }
        public string Parent { get; set; } = null;
        public bool IsPrimitive { get; set; } = false;
        public bool IsEnum { get; set; } = false;
        public string Reader { get; set; } = null;
        public string Writer { get; set; } = null;
        public bool NoTemplate { get; set; } = false;
        public bool IsIntegerType { get; set; } = false;
        public bool IsSignedType { get; set; } = false;
        public string BaseType { get; set; } = null;

        public string UsableType
        {
            get
            {
                if (!String.IsNullOrEmpty(Parent) && !IsEnum)
                    return Parent;
                return Name;
            }
        }

        public TypeInfo(string name)
        {
            Name = name;
        }
    }
}
