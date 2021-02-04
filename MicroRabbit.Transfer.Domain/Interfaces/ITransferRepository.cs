using MicroRabbit.Tranfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Tranfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        List<TransferLog> GetTransferLogs();
    }
}
