using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MivroRabbit.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        // GET: api/<TransferController>
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        [HttpGet]
        public ActionResult GetTransferDetails()
        {
            var response = _transferService.GetTransferLogs();
            return Ok(response);
        }
    }
}
