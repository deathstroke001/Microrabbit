using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly ILogger<BankingController> _logger;

        public BankingController(ILogger<BankingController> logger,IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            _logger = logger;
        }

        [HttpGet("GetAccounts")]
        public ActionResult Get()
        {
            var response = _accountRepository.GetAccounts();

            return Ok(response);
        }
    }
}
