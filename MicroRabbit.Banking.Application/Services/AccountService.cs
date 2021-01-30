using Microrabbit.Domain.Core.Bus;
using MicroRabbit.Banking.Application.Interaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;
        public AccountService(IAccountRepository accountRepository,IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Tranfer(AccountTransfer transfer)
        {
            var createtransferCommand = new CreateTransferCommand(
                transfer.Accountfrom,
                transfer.AccountTo,
                transfer.TransferAmount
                );
            _eventBus.SendCommand(createtransferCommand);
        }
    }
}
