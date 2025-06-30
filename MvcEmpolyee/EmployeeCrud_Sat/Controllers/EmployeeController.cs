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
        public async Task<IActionResult> Index()
        {
            var res =  await _employeeService.GetAllEmployees();

                
            return View();
        }


    }
}
