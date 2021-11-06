using Microsoft.AspNetCore.Mvc;

namespace PommermanAgentDotNet.Controllers
{
    [ApiController]
    [Route("ping")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Pong";
        }
    }
}
