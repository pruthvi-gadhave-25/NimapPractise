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
            try
            {
                var res = await _employeeService.GetAllEmployees();                
                return View(res);
            }
            catch(Exception ex)
            {   
                Console.WriteLine(ex.Message);
                return Content("Error : ", ex.Message);
            }
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

        public async Task<IActionResult> Edit(int id)
        {
            //var emp = await _employeeService.GetEmployeeByIdAsync(id);
            //if (emp == null) return NotFound();

            ////var dto = new UpdateEmployeeDto
            ////{
            ////    Id = emp.Id,
            ////    Name = emp.Name,
            ////    Email = emp.Email,
            ////    Position = emp.Position
            ////};
            //return View("EditEmployee", dto);
            return RedirectToAction("Index");
        }
      

        [HttpPost]
        public IActionResult Delete(string id)
        {
            // delete logic
            return RedirectToAction("Index");
        }

    }
}
