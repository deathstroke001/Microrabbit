using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public long AccountTo { get; set; }
        public long Accountfrom { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
