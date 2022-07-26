using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using Dapper;
using System.Data.SqlClient;
using CRUD.Models;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataBaseController : ControllerBase
    {
        String connectionString = "Data Source=CHNLAP48;Integrated Security=True;Database=student;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        [HttpPost("post")]
        public async Task<IActionResult> insertPost(JsonElement obj)
        {
            var reqObj = obj.GetRawText();
            var payload = JsonConvert.DeserializeObject<StudentInfo>(reqObj);
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    var query = $"insert into [dbo].[studentInfo] (firstName,lastName,age,gender,department) values (@firstName,@lastName,@age,@gender,@department) select cast(scope_identity() as int)";
                    var result = await connection.QueryAsync(query, payload);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                return Ok(payload);
            }
        }


    }
}
