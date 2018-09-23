using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.Tools
{
    /// <summary>
    /// Stores option values.
    /// </summary>
    internal static class Options
    {
        internal static bool ErrorOnly { get; set; } = false;
        internal static bool ApplyFilterOnLoad { get; set; } = true;
    }
}
