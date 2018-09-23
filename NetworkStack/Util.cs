using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network
{
    class Util
    {
        /// <summary>
        /// Compares two values, with special cases if the value has wrapped
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static short OverflowCompare(ushort v1, ushort v2)
        {
            if (v1 == v2)
                return 0;
            else
            {
                ushort diff = (ushort)(v1 - v2);
                short result = 1;
                if (v1 < v2)
                {
                    diff = (ushort)(v2 - v1);
                    result = -1;
                }
                if(diff > 0x7FFFu)
                {
                    result = (short)-result;
                }
                return result;
            }
        }
    }
}
