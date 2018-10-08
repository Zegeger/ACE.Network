using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network
{
    public static class Util
    {
        /// <summary>
        /// Determines if the value is newer then the given value.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNewer(this ushort v1, ushort value)
        {
            return OverflowCompare(v1, value) > 1;
        }

        /// <summary>
        /// Determines if the value is newer then the given value.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNewer(this uint v1, uint value)
        {
            return OverflowCompare(v1, value) > 1;
        }

        /// <summary>
        /// Compares two values, with special cases if the value has wrapped
        /// </summary>
        /// <param name="v1">First Value</param>
        /// <param name="v2">Second Value</param>
        /// <returns>Returns 0 if they are equal, -1 if v1 is less then v2, or 1 if v1 is greater then v2</returns>
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

        /// <summary>
        /// Compares two values, with special cases if the value has wrapped
        /// </summary>
        /// <param name="v1">First Value</param>
        /// <param name="v2">Second Value</param>
        /// <returns>Returns 0 if they are equal, -1 if v1 is less then v2, or 1 if v1 is greater then v2</returns>
        public static short OverflowCompare(uint v1, uint v2)
        {
            if (v1 == v2)
                return 0;
            else
            {
                uint diff = v1 - v2;
                short result = 1;
                if (v1 < v2)
                {
                    diff = v2 - v1;
                    result = -1;
                }
                if (diff > 0x7FFFFFFFu)
                {
                    result = (short)-result;
                }
                return result;
            }
        }
    }
}
