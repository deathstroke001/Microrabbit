using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Tranfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public long FromAccount { get; set; }
        public long ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
