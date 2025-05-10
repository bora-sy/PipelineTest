using Microsoft.AspNetCore.Mvc;

namespace ASPPipTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<Controller> _logger;

        public Controller(ILogger<Controller> logger)
        {
            _logger = logger;
        }


        [HttpGet("")]
        public async Task<IActionResult> G()
        {
            return Ok("hmmm");
        }
        
        [HttpGet("healthz")]
        public async Task<IActionResult> Health()
        {
            return Ok("hello tehre");
        }
    }
}
