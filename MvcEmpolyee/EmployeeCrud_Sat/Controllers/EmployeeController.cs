using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud_Sat.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet("get/employees")]
        public async Task<IActionResult> Index()
        {
            var res =  await _employeeService.GetAllEmployees();
           
            return View(res);
        }

        [HttpPost("add/employee")]
        public async Task<IActionResult> Add(AddEmployeeDto employee)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEmployee", employee); 
            }

            var res = await _employeeService.AddEmployeeAsync(employee);

            if (res == null)
            {
                return View("NotFoundData"); 
            }

            return RedirectToAction("Index"); 
        }


        [HttpGet]
        public async Task<IActionResult> GetAddEmployee()
        {
            return View("AddEmployee");
        }

    }
}
