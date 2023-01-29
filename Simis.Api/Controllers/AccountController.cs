using Microsoft.AspNetCore.Mvc;

namespace Simis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {        
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}