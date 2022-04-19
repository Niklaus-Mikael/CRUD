using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;
namespace CRUD.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReturnTypeController : ControllerBase
    {
        public string returnString()
        {
            return "string value";
        }

        public ExampleModel returnObject()
        {
            ExampleModel model = new ExampleModel()
            {
                id = 1,
                name = "soundar",
                age = 5
            };
            // var returnString = JsonSerializer.Serialize(model);
            return model;
        }

        public List<ExampleModel> returnList()
        {
            return new List<ExampleModel>
            {
                new ExampleModel() { id = 1, name = "Niklaus", age = 22 },
                new ExampleModel() { id = 2, name ="Mikael",age = 55}
            };
        }

        public IEnumerable<ExampleModel> returnEnumerable()
        {
            return new List<ExampleModel>
            {
                new ExampleModel() { id = 1, name = "Niklaus", age = 22 },
                new ExampleModel() { id = 2, name ="Mikael",age = 55}
            };
        }

        [Route("{id}")]
        public IActionResult returnActionResult(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return  Ok(new List<ExampleModel>
            {
                new ExampleModel() { id = 1, name = "Niklaus", age = 22 },
                new ExampleModel() { id = 2, name ="Mikael",age = 55}
            }
            );
        }

        [Route("{id}/basics")]
        public ActionResult<List<ExampleModel>> returnActionResultType(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return new List<ExampleModel>
            {
                new ExampleModel() { id = 1, name = "Niklaus", age = 22 },
                new ExampleModel() { id = 2, name ="Mikael",age = 55}
            };
        }

    }
}
