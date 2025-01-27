using Microsoft.AspNetCore.Mvc;

namespace EpiDocAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Health()
        {
            return Ok("Server is alive");
        }
    }
}
