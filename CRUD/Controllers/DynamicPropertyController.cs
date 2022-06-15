using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicPropertyController : ControllerBase
    {

        [HttpPost("dummy")]
        public IActionResult dummy([FromBody] JsonElement obj)
        {
            var temp = obj.GetRawText();
            var deObj = JsonConvert.DeserializeObject<dynamic>(temp);
            var type = deObj.GetType(); //if its JObject
            //get property names from JObject
            var reflection = deObj.Properties();
            foreach(var property in reflection)
            {
                var JObjName = property.Name;
            }
            return Ok();
        }

        [HttpPost("checkClassConv")]
        public IActionResult checkClassConversion([FromBody] JsonElement obj)
        {
            var temp = obj.GetRawText();
            var deObj = JsonConvert.DeserializeObject<Dummy>(temp);
            var type = deObj.GetType(); //if its  just an Object
            //get property names from normal Object 
            var reflection = deObj.GetType().GetProperties();
            foreach (var property in reflection)
            {
                var JObjName = property.Name;
            }
            return Ok();
        }

    }
    public class Dummy
    {
        public string Name { get; set; }
        public string Value { get; set; } 
    }
}
