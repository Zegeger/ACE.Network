////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Collections.Generic;
using ACE.Network.Enums;
using ACE.Network.Extensions;

namespace ACE.Network.Types
{
    /// <summary>
    /// Set of inventory items
    /// </summary>
    public class GeneratorQueue : IPackable
    {
        [MessageProperty]
        public PackableList<GeneratorQueueNode> Queue { get; } = new PackableList<GeneratorQueueNode>(ReadQueue, WriteQueue);
        


        public void Unpack(BinaryReader reader)
        {
            Queue.Unpack(reader);

        }

        public void Pack(BinaryWriter writer)
        {
            Queue.Pack(writer);

        }

        static GeneratorQueueNode ReadQueue(BinaryReader reader)
        {
            var item = new GeneratorQueueNode();
            item.Unpack(reader);
            return item;
        }
        
        static void WriteQueue(BinaryWriter writer, GeneratorQueueNode item)
        {
            item.Pack(writer);
        }
        

    }
}
