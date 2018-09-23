using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACE.Network
{
    /// <summary>
    /// Interface indicating a given class can be packed to a BinaryWriter or unpacked from a BinaryReader
    /// </summary>
    interface IPackable
    {
        void Pack(BinaryWriter writer);
        void Unpack(BinaryReader reader);
    }
}
