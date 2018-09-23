////////////////////////////////////////////////////////////////////////////////////
// This file is generated code.  Do not modify it's contents.
// If changes are required, update the message.xml in the TemplateBulder
// project and run the TemplateBuilder to recreate the files.
////////////////////////////////////////////////////////////////////////////////////
using System;

namespace ACE.Network.Enums
{
    public enum PacketHeaderFlags : uint
    {
        None = 0x00000000,
        
        /// <summary>
        /// Indicates the packet is a retransmission. Cannot be paired with 0x00000002.
        /// </summary>
        Retransmission = 0x00000001,
        
        /// <summary>
        /// Indicates the checksum has been encrypted. Cannot be paired with 0x00000001.
        /// </summary>
        EncryptedChecksum = 0x00000002,
        
        /// <summary>
        /// Indicates the packet contains blob fragments.
        /// </summary>
        BlobFragments = 0x00000004,
        
        /// <summary>
        /// Sent by the server to confirm connection to the new server.
        /// </summary>
        ServerSwitch = 0x00000100,
        
        /// <summary>
        /// Seems to send a socket address structure.  Not sure if this was used.
        /// </summary>
        SockAddr = 0x00000200,
        
        /// <summary>
        /// Maybe a response to 0x200?  Carries no data.
        /// </summary>
        Unknown1 = 0x00000400,
        
        /// <summary>
        /// Sent by the server when directing the client to connect to a different IP/Port
        /// </summary>
        Referral = 0x00000800,
        
        /// <summary>
        /// Sent when requesting a retransmission, indicating we did not receive one or more sequence IDs
        /// </summary>
        NegativeAck = 0x00001000,
        
        /// <summary>
        /// Sent if retransmission is not possible, asking us to clear those sequence IDs out of our pending list.
        /// </summary>
        EmptyAck = 0x00002000,
        
        /// <summary>
        /// Sent to confirm receiving sequences IDs up to the one provided
        /// </summary>
        PositiveAck = 0x00004000,
        
        /// <summary>
        /// Sent when disconnecting from a game server (not from the game, but perhaps while switching from one server to a different one)
        /// </summary>
        Disconnect = 0x00008000,
        
        /// <summary>
        /// Sent by the client when logging into the game.
        /// </summary>
        LoginRequest = 0x00010000,
        
        /// <summary>
        /// Sent by the client to start connecting to the location provided in the referral.
        /// </summary>
        ServerSwitchRequest = 0x00020000,
        
        /// <summary>
        /// Sent by the server to indicate the client can connect.
        /// </summary>
        ConnectRequest = 0x00040000,
        
        /// <summary>
        /// Sent by the client to confirm 
        /// </summary>
        ConnectResponse = 0x00080000,
        
        /// <summary>
        /// Some kind of network error message
        /// </summary>
        NetError = 0x00100000,
        
        /// <summary>
        /// Sent when ending a connection to a world server
        /// </summary>
        CloseConnection = 0x00200000,
        
        /// <summary>
        /// Sent by the client. Some kind of command from the client.  Client seems to only send noOp.  Sent every 220 intervals.
        /// </summary>
        CICMDCommand = 0x00400000,
        
        /// <summary>
        /// Transmits high resolution time for gear detection.
        /// </summary>
        TimeSync = 0x01000000,
        
        /// <summary>
        /// Sent by the client. Ping request.
        /// </summary>
        EchoRequest = 0x02000000,
        
        /// <summary>
        /// Sent by the server. Pong response.
        /// </summary>
        EchoResponse = 0x04000000,
        
        /// <summary>
        /// Both. Sent each time the interval changes, providing the bytes recieved during that interval period.
        /// </summary>
        Flow = 0x08000000
    }
}
