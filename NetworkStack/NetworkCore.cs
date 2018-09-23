using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ACE.Network.Enums;
using ACE.Network.Packets;
using ACE.Network.Packets.Headers;

namespace ACE.Network
{
    /// <summary>
    /// IN PROGRESS
    /// </summary>
    public class NetworkCore
    {
        public NetworkType Type { get; }
        public uint MaxSessions { get; }

        private ServerNetworkSession[] _sessions;

        private ReaderWriterLockSlim _sessionLock = new ReaderWriterLockSlim();

        public event EventHandler<SessionCreatedEventArgs> SessionCreated;

        public NetworkCore(NetworkType type, uint maxSessions = 1)
        {
            Type = type;
            MaxSessions = maxSessions;
            _sessions = new ServerNetworkSession[MaxSessions];
        }

        public void ProcessPacket(Packet p)
        {
            ValidateInboundPacket(p);
            if(p.Header.HasFlag(PacketHeaderFlags.LoginRequest))
            {
                CreateSession(p);
            }
            else
            {
                SendToSession(p);
            }
        }

        private void CreateSession(Packet p)
        {
            bool foundOpening = false;
            uint recId;

            _sessionLock.EnterUpgradeableReadLock();
            // Try to find the first open slot
            for (recId = 0; recId < _sessions.Length; recId++)
            {
                if (_sessions[recId] == null)
                {
                    foundOpening = true;
                    break;
                }
            }

            // Create our session, regardless of if we found one, we'll need it to send a failure response
            ServerNetworkSession session = new ServerNetworkSession(p.IPAddress, recId);

            // We didn't find a open slot. Reject with error.
            if(!foundOpening)
            {
                session.SendError();
                session = null;
            }
            // We found a session with the same IP and Port.  Reject with error.
            else if (_sessions.FirstOrDefault(x => x.IPAddress == p.IPAddress) != null)
            {
                session.SendError();
                session = null;
            }
            
            if(session != null)
            {
                _sessionLock.EnterWriteLock();
                _sessions[recId] = session;
                _sessionLock.ExitWriteLock();
            }

            _sessionLock.ExitUpgradeableReadLock();
            if(session != null)
            {
                SessionCreated?.Invoke(this, new SessionCreatedEventArgs(session));
                session.ProcessPacket(p);
            }
        }

        private void SendToSession(Packet p)
        {
            if(p.RecId < _sessions.Length)
            {
                var session = _sessions[p.RecId];
                if (session != null)
                    session.ProcessPacket(p);
            }
        }

        private bool ValidateInboundPacket(Packet p)
        {
            
            if (
                p.Header.HasFlag(PacketHeaderFlags.LoginRequest) ||
                p.Header.HasFlag(PacketHeaderFlags.ConnectResponse) 
                )
            {
                if (Type == NetworkType.Server)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (p.Header.HasFlag(PacketHeaderFlags.ConnectRequest))
            {
                if (Type == NetworkType.Client)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
