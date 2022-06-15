using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RouteConstraintController : ControllerBase
    {
        [HttpGet("{id:int:min(10)}")]
        //int bool datetime double float etc
        //min() max()
        public string getById(int id)
        {
            return "employee id " + id;
        }
      
        [HttpGet("{id:minlength(7)}")]
        //minlength() maxlength() length() range(from,to) alpha \\used to check just alphabets
        //required
        //regex
        [HttpGet]
        public string getByName(string id)
        {
            return "hello " + id;
        }

        [HttpGet("{id:regex(a(b|c))}")]
        public string getByRegex(string id)
        {
            return "regex method";
        }
    }
}
