using System;
using RabbitMq.Core.Events;

namespace RabbitMq.Core.Commands
{
    public abstract class Command: Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}