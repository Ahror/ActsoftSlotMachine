using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ActsoftSlotMachine.Models;
using ActsoftSlotMachine.Abstractions.Services;

namespace ActsoftSlotMachine.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SpinController : Controller
    {
        private readonly ILogger<SpinController> _logger;
        private readonly ISpinningService _spinningService;

        public SpinController(ILogger<SpinController> logger, ISpinningService spinningService)
        {
            _logger = logger;
            _spinningService = spinningService;
        }

        [HttpGet]
        public IActionResult Spin(int creditAmount)
        {
            var spinResult = _spinningService.Spin(creditAmount);
            return Ok(SpinViewModel.Create(spinResult));
        }

    }
}
