using System;

namespace ACE.Network.Tools.TemplateBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var tr = new TemplateWriter(@"..\..\..\..\NetworkStack\");
            tr.CreateFromXMLFile("messages.xml");
            //Console.ReadLine();
        }
    }
}
