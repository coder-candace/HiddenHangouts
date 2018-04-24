using HiddenHangouts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HiddenHangouts.Controllers
{
    [Route("api/hangouts")]
    public class HangoutsController : Controller
    {
        private ILogger<HangoutsController> _logger;

        public HangoutsController(ILogger<HangoutsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetHangouts()
        {
            return Ok("get all hangouts");
        }

        [HttpPost]
        public IActionResult CreateHangout(
            [FromBody] Hangout hangout)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateHangout( int id,
            [FromBody] Hangout hangout)
        {
            return Ok();
        }
    }
}