using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validating.Models;

namespace Validating.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult createCustomer([FromBody] Customer customer)
        {
            return Ok(customer);
        }
    }
}
