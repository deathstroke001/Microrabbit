
using MicroRabbit.Tranfer.Domain.Interfaces;
using MicroRabbit.Tranfer.Domain.Models;
using MicroRabbit.Transfer.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;       
        }
        public List<TransferLog> GetTransferLogs()
        {
            var response = _ctx.transferLogs.ToList();
            return response;
        }
        public void Add(TransferLog transferLog)
        {
            _ctx.transferLogs.Add(transferLog);
            _ctx.SaveChanges();
        }
    }
}
