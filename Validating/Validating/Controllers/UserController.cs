using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validating.Models;

namespace Validating.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            return Ok(user);
        }
    }
}
