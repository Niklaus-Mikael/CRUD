using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteConstraintController : ControllerBase
    {
        [Route("{id:int:min(10)}")]
        //int bool datetime double float etc
        //min() max()
        public string getById(int id)
        {
            return "employee id " + id;
        }

        [Route("{id:minlength(7)}")]
        //minlength() maxlength() length() range(from,to) alpha \\used to check just alphabets
        //required
        //regex
        public string getByName(string id)
        {
            return "hello " + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string getByRegex(string id)
        {
            return "regex method";
        }
    }
}
