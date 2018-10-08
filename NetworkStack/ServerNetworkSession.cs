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
        

        public ServerNetworkSession(IPEndPoint ip, uint recId) : base(ip, recId, NetworkType.Server)
        {
            
        }

        public void SendError()
        {

        }

        public override void ProcessPacket(Packet p)
        {
            base.ProcessPacket(p);
        }

        protected override bool VerifyPacket(Packet p)
        {
            return true;
        }
    }
}
