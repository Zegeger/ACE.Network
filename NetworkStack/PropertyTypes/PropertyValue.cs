using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ACE.Network.PropertyTypes
{
    /// <summary>
    /// Abstract base class for all property values
    /// </summary>
    public abstract class PropertyValue : IPackable
    {
        virtual public void Pack(BinaryWriter writer)
        {
            
        }

        virtual public void Unpack(BinaryReader reader)
        {
            
        }
    }
}
