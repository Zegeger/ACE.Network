using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACE.Network.Types
{
    /// <summary>
    /// Abstract base class for network tables.
    /// </summary>
    /// <typeparam name="T">Generic type for table keys</typeparam>
    /// <typeparam name="U">Generic type for table values</typeparam>
    public abstract class BaseTable<T, U> : Dictionary<T, U>, IPackable
    {
        // Delegates for reading and writing table items
        public delegate KeyValuePair<T, U> ReadFunction(BinaryReader reader);
        public delegate void WriteFunction(BinaryWriter writer, KeyValuePair<T, U> pair);

        protected ReadFunction readFunc;
        protected WriteFunction writeFunc;

        public BaseTable(ReadFunction ReadFunc, WriteFunction WriteFunc)
        {
            readFunc = ReadFunc;
            writeFunc = WriteFunc;
        }

        public abstract void Unpack(BinaryReader reader);
        public abstract void Pack(BinaryWriter writer);
    }
}
