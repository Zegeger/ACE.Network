using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;
using log4net;
using System.Diagnostics;

namespace ACE.Network.Extensions
{
    public static class Log4NetExtensions
    {
        /// <summary>
        /// Writes an error message if the boolean condition is not true, only when conditional DEBUG is present.
        /// </summary>
        /// <param name="log">Log4Net log to write to</param>
        /// <param name="condition">Boolean condition to evaluate</param>
        /// <param name="message">Message to write</param>
        [ConditionalAttribute("DEBUG")]
        public static void DebugAssert(this ILog log, bool condition, string message = "Assert Failure")
        {
            if (!condition)
                log.Error(message, new Exception());
        }

        /// <summary>
        /// Writes an error message and throws an exception if the boolean condition is not true
        /// </summary>
        /// <param name="log">Log4Net log to write to</param>
        /// <param name="condition">Boolean condition to evaluate</param>
        /// <param name="message">Message to write</param>
        public static void Assert(this ILog log, bool condition, string message)
        {
            if (!condition)
            {
                var ex = new Exception(message);
                log.Error(message, ex);
                throw ex;
            }
        }
    }
}
