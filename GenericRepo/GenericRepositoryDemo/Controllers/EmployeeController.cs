using GenericRepositoryDemo.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController :ControllerBase
    {

        private  readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
           _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var res =  await _employeeService.GetAllEmployee();

            return Ok(res);
        }

        [HttpGet("get/employee/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id )
        {
            var res = await _employeeService.GetEmployeeAsync(id);

            return Ok(res);
        }

        [HttpPost("add/employee")]
        public async Task<IActionResult> AddEmployee(Employee e)
        {
            await _employeeService.AddEmployee(e);

            return Ok("Added ");
        }
    }
}
