using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using ACE.Network.Tools.TemplateBuilder.Extensions;
using System.Collections;

namespace ACE.Network.Tools.TemplateBuilder
{
    class PackableClassInstanceBase
    {
        protected CodeStringBuilder properties = new CodeStringBuilder(2);
        protected CodeStringBuilder pack = new CodeStringBuilder(3);
        protected CodeStringBuilder unpack = new CodeStringBuilder(3);
        protected CodeStringBuilder collectionFunctions = new CodeStringBuilder(2);

        Dictionary<string, string> propertyMap = new Dictionary<string, string>();

        int tempCount = 1;

        protected string baseName = "";

        protected void ProcessChildElements(XElement node, bool output = true)
        {
            foreach (var propertyNode in node.Elements())
            {
                switch (propertyNode.Name.ToString())
                {
                    case "member":
                    case "field":
                        ProcessField(propertyNode, output);
                        break;
                    case "vector":
                        ProcessVector(propertyNode, output);
                        break;
                    case "switch":
                        ProcessSwitch(propertyNode, output);
                        break;
                    case "maskmap":
                        ProcessMaskmap(propertyNode, output);
                        break;
                    case "if":
                        ProcessIf(propertyNode, output);
                        break;
                    case "align":
                        ProcessAlign(propertyNode);
                        break;

                }
            }
        }

        void ProcessField(XElement node, bool output = true)
        {
            string name = node.GetAttribute("name").Capitalize();
            string type = node.GetAttribute("type");
            var typeInfo = TypeTable.GetType(type);

            string staticValue = node.GetAttribute("staticValue", false);

            if (node.CheckAttribute("unused", "true") || !String.IsNullOrWhiteSpace(staticValue))
            {
                if (String.IsNullOrWhiteSpace(staticValue))
                    staticValue = "0";
                if (typeInfo != null && typeInfo.UsableType == "string")
                    staticValue = "\"" + staticValue + "\"";
                string temp = "temp" + tempCount++;
                unpack.AppendLine("var {0} = {1}; // Unused value", temp, Util.CreateReaderString(typeInfo));
                unpack.AppendLineRaw("#if NETWORKVALIDATION");
                unpack.AppendLine("if({0} != {1})", temp, staticValue);
                unpack.OpenBlock();
                unpack.AppendLine("throw new Exception(\"Recieved value different from static on {0}, expected: {1}, actual \" + {2});", baseName, staticValue.Replace("\"", ""), temp);
                unpack.CloseBlock();
                unpack.AppendLineRaw("#endif");
                pack.AppendLine(Util.CreateStaticWriterString(typeInfo, staticValue) + "; // Unused value");
                return;
            }

            string defaultValue = node.GetAttribute("defaultValue", false);

            bool propertyExists = propertyMap.ContainsKey(name);
            if (!propertyExists)
                propertyMap.Add(name, type);

            if (node.HasElements)
            {
                unpack.AppendVariable(type, name, Util.CreateReaderString(typeInfo));
                if (output)
                    pack.AppendVariable(type, name, "0");
                foreach (var childNode in node.Elements())
                {
                    if(childNode.Name == "submember" || childNode.Name == "subfield")
                        ProcessSubfield(name, type, childNode, output);
                }
                pack.AppendLine(Util.CreateWriterString(typeInfo, name) + ";");
            }
            else
            {
                if (!propertyExists)
                {
                    string text = node.GetAttribute("text", false);
                    if (!String.IsNullOrWhiteSpace(text))
                    {
                        properties.AppendSummary(text);
                    }
                }
                
                if (node.CheckAttribute("isArray", "true"))
                {
                    string length = node.GetAttribute("length").Capitalize();
                    if (!propertyExists)
                        properties.AppendReadWriteProperty(typeInfo.UsableType + "[]", name);
                    unpack.AppendLine("{0} = new {1}[{2}];", name, typeInfo.UsableType, length);
                    unpack.AppendLine("for(int i = 0; i < {0}; i++)", length);
                    unpack.OpenBlock();
                    unpack.AppendLine("{0}[i] = {1};", name, Util.CreateReaderString(typeInfo));
                    unpack.CloseBlock();

                    if (output)
                    {
                        pack.AppendLine("for(int i = 0; i < {0}; i++)", length);
                        pack.OpenBlock();
                        pack.AppendLine(Util.CreateWriterString(typeInfo, name) + ";");
                        pack.CloseBlock();
                    }
                }
                else if (type == "List")
                {
                    string genericType = node.GetAttribute("genericType");
                    TypeInfo genericTypeInfo = TypeTable.GetType(genericType);
                    string length = node.GetAttribute("length").Capitalize();
                    if (!propertyExists)
                        properties.AppendReadOnlyGenericProperty(type, genericTypeInfo.UsableType, name);
                    unpack.AppendLine(String.Format("{0}.Clear();", name));
                    unpack.AppendLine("for(int i = 0; i < {0}; i++)", length);
                    unpack.OpenBlock();
                    WriteListReadString(genericType, name);
                    unpack.CloseBlock();

                    if (output)
                    {
                        pack.AppendLine("for(int i = 0; i < {0}; i++)", length);
                        pack.OpenBlock();
                        WriteListWriteString(genericType, name + "[i]");
                        pack.CloseBlock();
                    }
                }
                else if (typeInfo.IsPrimitive)
                {
                    if (!propertyExists)
                        properties.AppendReadWriteProperty(typeInfo.UsableType, name, defaultValue);
                    unpack.AppendLine("{0} = {1};", name, Util.CreateReaderString(typeInfo));
                    if (output)
                        pack.AppendLine(Util.CreateWriterString(typeInfo, name) + ";");
                }
                else if (typeInfo.IsEnum)
                {
                    if (!propertyExists)
                        properties.AppendReadWriteProperty(typeInfo.Name, name, defaultValue);
                    var streamType = node.GetAttribute("streamType", false);
                    EnumInfo enumType = (EnumInfo)typeInfo;
                    if (String.IsNullOrEmpty(streamType))
                    {
                        unpack.AppendLine("{0} = {1};", name, Util.CreateReaderString(enumType));
                        if (output)
                            pack.AppendLine(Util.CreateWriterString(enumType, name) + ";");
                    }
                    else
                    {
                        TypeInfo streamInfoType = TypeTable.GetType(streamType);
                        unpack.AppendLine("{0} = {1};", name, Util.CreateReaderString(enumType, streamInfoType));
                        if (output)
                            pack.AppendLine(Util.CreateWriterString(streamInfoType, name, true) + ";");
                    }
                    
                }
                else
                {
                    if(typeInfo.BaseType == "List")
                    {
                        var genericType = node.GetAttribute("genericType");
                        var genericTypeInfo = TypeTable.GetType(genericType);
                        string readFunc = "Read" + name;
                        string writeFunc = "Write" + name;
                        if (!propertyExists)
                        {
                            collectionFunctions.AppendLine("static {0} {1}(BinaryReader reader)", genericTypeInfo.UsableType, readFunc);
                            collectionFunctions.OpenBlock();
                            WriteReaderString(genericTypeInfo, "item", collectionFunctions, false);
                            collectionFunctions.AppendLine("return item;", genericTypeInfo.UsableType);
                            collectionFunctions.CloseBlock();
                            collectionFunctions.AppendLine();

                            collectionFunctions.AppendLine("static void {1}(BinaryWriter writer, {0} item)", genericTypeInfo.UsableType, writeFunc);
                            collectionFunctions.OpenBlock();
                            WriteWriterString(genericTypeInfo, "item", collectionFunctions);
                            collectionFunctions.CloseBlock();
                            collectionFunctions.AppendLine();

                            properties.AppendReadOnlyGenericProperty(type, genericTypeInfo.UsableType, name, readFunc, writeFunc);
                        }
                    }
                    else if(typeInfo.BaseType == "Dictionary")
                    {
                        var genericKey = node.GetAttribute("genericKey");
                        var genericKeyInfo = TypeTable.GetType(genericKey);
                        var genericValue = node.GetAttribute("genericValue");
                        var genericValueInfo = TypeTable.GetType(genericValue);
                        string readFunc = "Read" + name;
                        string writeFunc = "Write" + name;
                        if (!propertyExists)
                        {
                            collectionFunctions.AppendLine("static KeyValuePair<{0}, {1}> {2}(BinaryReader reader)", genericKeyInfo.UsableType, genericValueInfo.UsableType, readFunc);
                            collectionFunctions.OpenBlock();
                            WriteReaderString(genericKeyInfo, "key", collectionFunctions, false);
                            WriteReaderString(genericValueInfo, "val", collectionFunctions, false);
                            collectionFunctions.AppendLine("return new KeyValuePair<{0}, {1}>(key, val);", genericKeyInfo.UsableType, genericValueInfo.UsableType);
                            collectionFunctions.CloseBlock();
                            collectionFunctions.AppendLine();

                            collectionFunctions.AppendLine("static void {2}(BinaryWriter writer, KeyValuePair<{0}, {1}> pair)", genericKeyInfo.UsableType, genericValueInfo.UsableType, writeFunc);
                            collectionFunctions.OpenBlock();
                            WriteWriterString(genericKeyInfo, "pair.Key", collectionFunctions);
                            WriteWriterString(genericValueInfo, "pair.Value", collectionFunctions);
                            collectionFunctions.CloseBlock();
                            collectionFunctions.AppendLine();

                            properties.AppendReadOnlyKeyValueProperty(type, genericKeyInfo.UsableType, genericValueInfo.UsableType, name, readFunc, writeFunc);
                        }
                    }
                    else
                    {
                        if (!propertyExists)
                            properties.AppendReadOnlyProperty(type, name);
                    }
                    
                    unpack.AppendLine("{0}.Unpack(reader);", name);
                    if (output)
                        pack.AppendLine("{0}.Pack(writer);", name);
                }
            }
        }

        void WriteReaderString(TypeInfo typeInfo, string name, CodeStringBuilder builder, bool field = true)
        {
            if (typeInfo.IsPrimitive)
            {
                if (!field)
                    builder.AppendLine("var {0} = {1};", name, Util.CreateReaderString(typeInfo));
                else
                    builder.AppendLine("{0} = {1};", name, Util.CreateReaderString(typeInfo));

            }
            else if (typeInfo.IsEnum)
            {
                EnumInfo enumType = (EnumInfo)typeInfo;
                if (!field)
                {
                    builder.AppendLine("var {0} = {1};", name, Util.CreateReaderString(enumType));
                }
                else
                {
                    builder.AppendLine("{0} = {1};", name, Util.CreateReaderString(enumType));
                }
            }
            else
            {
                if (!field)
                    builder.AppendLine("var {0} = new {1}();", name, typeInfo.UsableType);
                builder.AppendLine("{0}.Unpack(reader);", name);
            }
        }

        void WriteWriterString(TypeInfo typeInfo, string name, CodeStringBuilder builder)
        {
            if (typeInfo.IsPrimitive)
            {
                builder.AppendLine(Util.CreateWriterString(typeInfo, name) + ";");
            }
            else if (typeInfo.IsEnum)
            {
                EnumInfo enumType = (EnumInfo)typeInfo;
                builder.AppendLine(Util.CreateWriterString(enumType, name) + ";");
            }
            else
            {
                builder.AppendLine("{0}.Pack(writer);", name);
            }
        }

        void WriteListReadString(string type, string name)
        {
            var typeInfo = TypeTable.GetType(type);
            if (typeInfo.IsPrimitive)
            {
                unpack.AppendLine("{0}.Add({1});", name, Util.CreateReaderString(typeInfo));
            }
            else if (typeInfo.IsEnum)
            {
                EnumInfo enumType = (EnumInfo)typeInfo;
                unpack.AppendLine("{0}.Add({1});", name, Util.CreateReaderString(enumType));
            }
            else
            {
                unpack.AppendLine("{0} newItem = new {0}();", type);
                unpack.AppendLine("newItem.Unpack(reader);");
                unpack.AppendLine("{0}.Add(newItem);", name);
            }
        }

        void WriteListWriteString(string type, string name)
        {
            var typeInfo = TypeTable.GetType(type);
            if (typeInfo.IsPrimitive)
            {
                pack.AppendLine(Util.CreateWriterString(typeInfo, name) + ";");
            }
            else if (typeInfo.IsEnum)
            {
                EnumInfo enumInfo = (EnumInfo)typeInfo;
                pack.AppendLine(Util.CreateWriterString(enumInfo, name) + ";");
            }
            else
            {
                pack.AppendLine(String.Format("{0}.Pack(writer);", name));
            }
        }

        void ProcessSubfield(string supername, string supertype, XElement node, bool output = true)
        {
            string type = node.GetAttribute("type");
            string name = node.GetAttribute("name").Capitalize();
            TypeInfo typeInfo = TypeTable.GetType(type);
            bool propertyExists = propertyMap.ContainsKey(name);
            if (!propertyExists)
            {
                propertyMap.Add(name, type);
                string text = node.GetAttribute("text", false);
                if (!String.IsNullOrWhiteSpace(text))
                {
                    properties.AppendSummary(text);
                }
            }
            if (!output)
                name = "Unused" + name;
            if (!propertyExists)
            {
                properties.AppendReadWriteProperty(type, name);
                properties.AppendLine();
            }
            string and = node.GetAttribute("and", false);
            string shift = node.GetAttribute("shift", false);
            if (!String.IsNullOrEmpty(and) && !String.IsNullOrEmpty(shift))
            {
                if (typeInfo.IsSignedType || supertype != type)
                {
                    unpack.AppendLine("{0} = ({4})({1} >> {2} & {3});", name, supername, shift, and, type);
                    pack.AppendLine("{0} |= ({4})({1} & {2} << {3});", supername, name, and, shift, supertype);
                }
                else
                {
                    unpack.AppendLine("{0} = ({4})({1} >> {2} & {3});", name, supername, shift, and, type);
                    pack.AppendLine("{0} |= ({4})({1} & {2} << {3});", supername, name, and, shift, supertype);
                }
            }
            else if (!String.IsNullOrEmpty(shift))
            {
                if (typeInfo.IsSignedType || supertype != type)
                {
                    unpack.AppendLine("{0} = ({3})({1} >> {2});", name, supername, shift, type);
                    pack.AppendLine("{0} |= ({3})({1} << {2});", supername, name, shift, supertype);
                }
                else
                {
                    unpack.AppendLine("{0} = ({3})({1} >> {2});", name, supername, shift, type);
                    pack.AppendLine("{0} |= ({3})({1} << {2});", supername, name, shift, supertype);
                }
            }
            else if (!String.IsNullOrEmpty(and))
            {
                if(typeInfo.IsSignedType)
                {
                    var andInt = Convert.ToInt32(and, 16);
                    BitArray ba = new BitArray(new int[] { andInt });
                    int pos;
                    for(pos = 0; pos < ba.Length; pos++)
                    {
                        if (!ba[pos])
                            break;
                    }
                    uint negCheck = (uint)Math.Pow(2, pos - 1);
                    string negativeCheck = String.Format("0x{0:X}", negCheck);
                    int size = negativeCheck.Replace("0x", "").Length;
                    int sizediff = Util.GetHexLength(type) - size;
                    string negativeOr = "0x" + new string('F', sizediff) + new string('0', size);
                    unpack.AppendLine("if(({0} & {1}) != 0) // Is the subvalue negative?", supername, negativeCheck);
                    unpack.Indent();
                    unpack.AppendLine("{0} = ({4})({1} & {2} | {3});", name, supername, and, negativeOr, type);
                    unpack.Unindent();
                    unpack.AppendLine("else");
                    unpack.Indent();
                    unpack.AppendLine("{0} = ({3})({1} & {2});", name, supername, and, type);
                    unpack.Unindent();
                }
                else
                {
                    unpack.AppendLine("{0} = ({3})({1} & {2});", name, supername, and, type);
                    pack.AppendLine("{0} |= ({3})({1} & {2});", supername, name, and, supertype);
                }
            }
        }

        void ProcessVector(XElement node, bool output = true)
        {
            string name = node.GetAttribute("name");
            string length = node.GetAttribute("length");
            string text = node.GetAttribute("text", false);
            unpack.AppendLine("for(int i = 0; i < {0}; i++)");
            unpack.OpenBlock();
            ProcessChildElements(node, false);
            unpack.CloseBlock();
        }

        void ProcessSwitch(XElement node, bool output = true)
        {
            string name = node.GetAttribute("name").Capitalize();
            string type = propertyMap[name];
            var typeInfo = TypeTable.GetType(type);
            unpack.AppendLine("switch({0})", name);
            unpack.OpenBlock();
            pack.AppendLine("switch({0})", name);
            pack.OpenBlock();
            foreach (XElement child in node.Elements())
            {
                if (child.Name == "case")
                {
                    string value = child.GetAttribute("value");
                    var values = value.Split('|');

                    foreach (var splitValue in values)
                    {
                        string caseValue = splitValue.Trim();
                        if (typeInfo.IsEnum)
                        {
                            EnumInfo enumInfo = (EnumInfo)typeInfo;
                            caseValue = type + "." + enumInfo.ValueMap.FirstOrDefault(x => x.Value == caseValue).Key;
                        }
                        switch (type)
                        {
                            case "string":
                                unpack.AppendLine("case \"{0}\":", caseValue);
                                pack.AppendLine("case \"{0}\":", caseValue);
                                break;
                            default:
                                unpack.AppendLine("case {0}:", caseValue);
                                pack.AppendLine("case {0}:", caseValue);
                                break;
                        }
                    }
                    unpack.Indent();
                    pack.Indent();
                    ProcessChildElements(child, output);
                    unpack.Unindent();
                    unpack.AppendLine("break;");
                    pack.Unindent();
                    pack.AppendLine("break;");
                }
            }
            unpack.CloseBlock();
            pack.CloseBlock();
        }

        void ProcessMaskmap(XElement node, bool output = true)
        {
            string name = node.GetAttribute("name").Capitalize();
            string type = propertyMap[name];
            TypeInfo typeInfo = TypeTable.GetType(type);
            foreach (XElement child in node.Elements())
            {
                if (child.Name == "mask")
                {
                    string value = child.GetAttribute("value");
                    bool negate = child.CheckAttribute("negate", "true");

                    string caseValue = value;
                    if (typeInfo.IsEnum)
                    {
                        EnumInfo enumInfo = (EnumInfo)typeInfo;
                        caseValue = type + "." + enumInfo.ValueMap.FirstOrDefault(x => x.Value == value).Key;
                    }

                    string op = "!=";
                    if (negate)
                        op = "==";

                    unpack.AppendLine("if(({0} & {1}) {2} 0)", name, caseValue, op);
                    unpack.OpenBlock();

                    pack.AppendLine("if(({0} & {1}) {2} 0)", name, caseValue, op);
                    pack.OpenBlock();

                    ProcessChildElements(child, output);

                    unpack.CloseBlock();
                    pack.CloseBlock();
                }
            }
        }

        void ProcessIf(XElement node, bool output = true)
        {
            string test = node.GetAttribute("test").Capitalize();
            var trueNode = node.Element("true");

            unpack.AppendLine("if({0})", test);
            unpack.OpenBlock();

            pack.AppendLine("if({0})", test);
            pack.OpenBlock();

            ProcessChildElements(trueNode, output);

            unpack.CloseBlock();
            pack.CloseBlock();

            var falseNode = node.Element("false");

            if (falseNode != null)
            {
                unpack.AppendLine("else", test);
                unpack.OpenBlock();

                pack.AppendLine("else", test);
                pack.OpenBlock();

                ProcessChildElements(falseNode, output);

                unpack.CloseBlock();
                pack.CloseBlock();
            }
        }

        void ProcessAlign(XElement node)
        {
            string type = node.GetAttribute("type");
            switch(type)
            {
                case "DWORD":
                    unpack.AppendLine("reader.Align();");
                    pack.AppendLine("writer.Align();");
                    break;
                case "WORD":
                    unpack.AppendLine("reader.Align(2);");
                    pack.AppendLine("writer.Align(2);");
                    break;
                case "QWORD":
                    unpack.AppendLine("reader.Align(8);");
                    pack.AppendLine("writer.Align(8);");
                    break;
            }
        }
    }
}
