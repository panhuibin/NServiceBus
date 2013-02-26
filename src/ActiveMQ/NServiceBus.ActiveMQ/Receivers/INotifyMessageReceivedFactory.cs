namespace NServiceBus.Transports.ActiveMQ.Receivers
{
    using System;

    public interface INotifyMessageReceivedFactory
    {
        INotifyMessageReceived CreateMessageReceiver(Func<TransportMessage, bool> tryProcessMessage, Action<string, Exception> endProcessMessage);
    }
}