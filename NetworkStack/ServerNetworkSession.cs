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
    public class ServerNetworkSession : BaseNetworkSession
    {
        

        public ServerNetworkSession(IPEndPoint ip, uint recId) : base(ip, recId)
        {
            
        }

        public void SendError()
        {

        }

        public override void ProcessPacket(Packet p)
        {
            base.ProcessPacket(p);
        }

        protected override bool VerifyPacketHeader(Packet p)
        {
            if (p.RecId > 0x100)
            {
                return false;
            }
            else
            {
                int diff = Util.OverflowCompare(p.Iteration, Iteration);
                if (diff < 0)
                {
                    return false;
                }
                if (diff > 0 && !p.Header.HasFlag(PacketHeaderFlags.LoginRequest))
                {
                    return false;
                }
                if (p.DataLen > 0xFFE0u)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
