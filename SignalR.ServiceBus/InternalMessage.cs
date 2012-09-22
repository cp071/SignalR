﻿namespace SignalR.ServiceBus
{
    using System;

    sealed class InternalMessage
    {
        readonly string stream;
        readonly ulong id;
        readonly Message[] messages;

        public InternalMessage(string stream, ulong id, Message[] messages)
        {
            this.stream = stream;
            this.id = id;
            this.messages = messages;
        }

        public Message[] Messages
        {
            get { return this.messages; }
        }

        public string Stream
        {
            get { return this.stream; }
        }

        public ulong Id
        {
            get { return this.id; }
        }
    }
}
