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
            //need to figure out how to get data from a data source
            //and then how to turn that data into its corresponding models
            return Ok("get all hangouts");
        }

        [HttpPost]
        public IActionResult CreateHangout(dynamic hangout)
        {
            var newHangout = new Hangout(hangout);
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