using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMethodController : ControllerBase
    {
        [Route("getText")]
        public string getText()
        {
            return " this is from getText method using route";
        }

        [Route("getById/{id}")]
        public string getById(int id)
        {
            return "this is the ID " + id;
        }

        [Route("search")]
        public string getValueWithQueryString(int id, string name, int age)
        {
            return "my id is " + id + " and name is " + name + " finally my age is " + age;
        }

        [Route("[action]")]
        public string tokenReplacementRoute()
        {
            return "use token[controller] for the controller name [action] for the methods in the controller class";
        }

        [Route("~/override")]
        public string OverRideMainRoute()
        {
            return "using ~/ we can override the main controller level route";
        }
    }
}
