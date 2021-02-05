using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Models.DTO
{
    public class TransferDTO
    {
        public long AccountTo { get; set; }
        public long Accountfrom { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
