using Microrabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public long From { get; private set; }
        public long To { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(long from,long to,decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
