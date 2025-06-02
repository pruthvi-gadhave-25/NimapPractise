using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Simulate adding the employee
            return Ok("Employee created successfully");
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID provided");
            }
            // Simulate fetching an employee
            return Ok(new Employee { Id = id, Name = "John Doe", Position = "Developer" });
        }

    }
}
