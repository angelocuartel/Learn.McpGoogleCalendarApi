using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelContextProtocol.Server;
using System.ComponentModel;

namespace Learn.McpGoogleCalendar.WebApi.Controllers
{
    [McpServerToolType]
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [McpServerTool, Description("Generate a list of testData.")]
        [HttpGet]
        public IActionResult GetTestData()
        {
            var testDataList = new List<TestData>
            {
                new TestData { Id = 1, Name = "Test One", CreatedAt = DateTime.UtcNow.AddDays(-2) },
                new TestData { Id = 2, Name = "Test Two", CreatedAt = DateTime.UtcNow.AddDays(-1) },
                new TestData { Id = 3, Name = "Test Three", CreatedAt = DateTime.UtcNow }
            };

            return Ok(testDataList);
        }
    }



    public class TestData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
