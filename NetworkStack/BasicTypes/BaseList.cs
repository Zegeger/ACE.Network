using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACE.Network.Types
{
    /// <summary>
    /// Abstract base class for network lists.
    /// </summary>
    /// <typeparam name="T">Generic type for the list</typeparam>
    public abstract class BaseList<T> : List<T>, IPackable
    {
        // Delegates for functions used to read or write individual elements in the list.
        public delegate T ReadFunction(BinaryReader reader);
        public delegate void WriteFunction(BinaryWriter writer, T item);

        protected ReadFunction readFunc;
        protected WriteFunction writeFunc;

        public BaseList(ReadFunction ReadFunc, WriteFunction WriteFunc)
        {
            readFunc = ReadFunc;
            writeFunc = WriteFunc;
        }

        public abstract void Unpack(BinaryReader reader);

        public abstract void Pack(BinaryWriter writer);
    }
}
