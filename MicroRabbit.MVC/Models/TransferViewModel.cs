using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Models
{
    public class TransferViewModel
    {
        public string TransferNotes { get; set; }
        public long FromAccount { get; set; }
        public long ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
