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
    public class ClientNetworkSession : BaseNetworkSession
    {
        

        public ClientNetworkSession(IPEndPoint ip, uint recId) : base(ip, recId, NetworkType.Client)
        {
            
        }

        public override void ProcessPacket(Packet p)
        {
            base.ProcessPacket(p);
        }

        protected override bool VerifyPacket(Packet p)
        {
            if (p.RecId > 0x100)
            {
                return false;
            }
            else
            {
                if (Timestamp > 0)
                {
                    if(p.IPAddress != IPAddress)
                    {
                        return false;
                    }
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
                else
                {
                    if(p.SeqID != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        protected override bool ProcessOptionalHeaders(Packet p)
        {
            var result = base.ProcessOptionalHeaders(p);
            if(p.Header > PacketHeaderFlags.NetError)
            {
                switch(p.Header)
                {
                    case PacketHeaderFlags.CloseConnection:
                        break;
                    case PacketHeaderFlags.EchoResponse:
                        //LinkStatusAverages
                        return true;
                    case PacketHeaderFlags.Flow:
                        return true;
                }
            }
            return result;
        }
    }
}
