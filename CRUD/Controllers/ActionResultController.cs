using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionResultController : ControllerBase
    {
        [HttpGet]
        public IActionResult getEmployee()
        {
            return Ok("fine");
        }
    }
}
