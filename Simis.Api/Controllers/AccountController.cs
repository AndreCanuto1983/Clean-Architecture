using Microsoft.AspNetCore.Mvc;

namespace Simis.Svc.Controllers
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