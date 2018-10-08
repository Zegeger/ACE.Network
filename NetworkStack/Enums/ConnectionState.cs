namespace ACE.Network.Enums
{
    /// <summary>
    /// The current connection state of a session
    /// </summary>
    public enum ConnectionState : ushort
    {
        Disconnected = 0,
        AwaitingWorldAuth = 1,
        AuthSent = 2,
        ConnectionRequestSent = 3,
        ConnectionRequestAcked = 4,
        Connected = 5,
        DisconnectReceived = 6,
        DisconnectSent = 7,
    }
}
