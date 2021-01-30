using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Microrabbit.Banking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountService _accountService;
        private readonly ILogger<BankingController> _logger;

        public BankingController(ILogger<BankingController> logger,IAccountRepository accountRepository, IAccountService accountService)
        {
            _accountRepository = accountRepository;
            _accountService = accountService;
            _logger = logger;
        }

        [HttpGet("GetAccounts")]
        public ActionResult Get()
        {
            var response = _accountRepository.GetAccounts();

            return Ok(response);
        }
        [HttpPost("TansferFund")]
        public ActionResult TansferFund(AccountTransfer transfer)
        {
            _accountService.Tranfer(transfer);
            return Ok(transfer);
        }
    }
}
