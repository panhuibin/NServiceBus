﻿namespace NServiceBus
{
    using System;
    using Pipeline;
    using Transport;

    class IncomingPhysicalMessageContext : IncomingContext, IIncomingPhysicalMessageContext
    {
        public IncomingPhysicalMessageContext(IncomingMessage message, IBehaviorContext parentContext)
            : base(message.MessageId, message.GetReplyToAddress(), message.Headers, parentContext)
        {
            Message = message;
        }

        public IncomingMessage Message { get; }

        public void UpdateMessage(ReadOnlyMemory<byte> body)
        {
            Message.UpdateBody(body);
        }
    }
}