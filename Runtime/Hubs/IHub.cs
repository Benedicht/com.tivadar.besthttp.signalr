using System;

using Best.SignalR.Messages;

namespace Best.SignalR.Hubs
{
    /// <summary>
    /// Interface to be able to hide internally used functions and properties.
    /// </summary>
    public interface IHub
    {
        Connection Connection { get; set; }

        bool Call(ClientMessage msg);
        bool HasSentMessageId(UInt64 id);
        void Close();
        void OnMethod(MethodCallMessage msg);
        void OnMessage(IServerMessage msg);
    }
}
