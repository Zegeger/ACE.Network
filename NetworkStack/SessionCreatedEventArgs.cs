using System;
using System.Collections.Generic;
using System.Text;

namespace ACE.Network
{
    /// <summary>
    /// Event args used when a new session is created
    /// </summary>
    public class SessionCreatedEventArgs
    {
        ServerNetworkSession Session { get; }

        public SessionCreatedEventArgs(ServerNetworkSession session)
        {
            Session = session;
        }
    }
}
