using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Interaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Tranfer(AccountTransfer transfer);
    }
}
