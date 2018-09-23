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
    public static class TypeTable
    {
        
        private static Dictionary<string, TypeInfo> typeTable = new Dictionary<string, TypeInfo>();

        public static bool TypeExists(string name)
        {
            return typeTable.ContainsKey(name);
        }

        public static TypeInfo GetType(string name)
        {
            if(TypeExists(name))
                return typeTable[name];
            return null;
        }

        public static void AddType(TypeInfo typeInfo)
        {
            typeTable.Add(typeInfo.Name, typeInfo);
        }
    }
}
