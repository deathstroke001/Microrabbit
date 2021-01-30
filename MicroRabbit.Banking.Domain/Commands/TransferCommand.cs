using Microrabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public long To { get; protected set; }
        public long From { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
