using System;
using System.Collections.Generic;
using System.Text;
using ACE.Network.Packets;
using ACE.Network.Enums;
using System.Net;

namespace ACE.Network
{
    /// <summary>
    /// IN PROGRESS
    /// </summary>
    public class BaseNetworkSession
    {
        public IPEndPoint IPAddress { get; }
        public uint RecId { get; }
        public ushort Iteration { get; }

        protected BaseNetworkSession(IPEndPoint ip, uint recId)
        {
            IPAddress = ip;
            RecId = recId;
        }

        protected virtual bool VerifyPacketHeader(Packet p)
        {
            return true;
        }

        public virtual void ProcessPacket(Packet p)
        {
            VerifyPacketHeader(p);
        }
    }
}
