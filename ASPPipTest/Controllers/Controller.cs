using Microsoft.AspNetCore.Mvc;

namespace ASPPipTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller(ILogger<Controller> _logger) : ControllerBase
    {
        public static int rand = Random.Shared.Next(0, 1000);



        [HttpGet("")]
        public async Task<IActionResult> G()
        {
            return Ok("hmmm");
        }
        
        [HttpGet("healthz")]
        public async Task<IActionResult> Health()
        {
            TimeSpan upt = DateTime.UtcNow - Program.AppBegin;

            int days = upt.Days;
            int hr = upt.Hours;
            int min = upt.Minutes;
            int sec = upt.Seconds;

            return Ok($"Rand: {rand}\nUptime: {days} day / {hr} hour / {min} minute / {sec} second");
        }
    }
}
