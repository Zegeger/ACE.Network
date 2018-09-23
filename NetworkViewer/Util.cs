using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools.NetworkViewer
{
    static class Util
    {
        public static byte[] ReverseBytes(byte[] value)
        {
            return value.Reverse().ToArray();
        }
    }
}
