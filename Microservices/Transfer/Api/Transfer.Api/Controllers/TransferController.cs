using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Transfer.Application.Interfaces;
using Transfer.Domain.Model;

namespace Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {

        private readonly ILogger<TransferController> _logger;
        private readonly ITransferService _transferService;

        public TransferController(ILogger<TransferController> logger, ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult<TransferLog> GetTransferLogs()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
