using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Models.ViewModels;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [HttpGet]
        public async Task<IActionResult> GetAddEmployee()
        {
            var countries = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "India" },
                new SelectListItem { Value = "2", Text = "France" },
                new SelectListItem { Value = "3", Text = "Spain" }
            };
            var states = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Delhi" },
                new SelectListItem { Value = "2", Text = "Paris" },
                new SelectListItem { Value = "3", Text = "Madrid" }
            };

            var cities = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "New Delhi" },
                new SelectListItem { Value = "2", Text = "Nice" },
                new SelectListItem { Value = "3", Text = "Barcelona" }
            };

            var model = new AddEmployeeDto
            {
                Countries = countries,
                States = states,
                Cities = cities
            };

            return View("AddEmployeeForm", model);
        }

        [HttpPost("add/employee")]
        public async Task<IActionResult> Add(AddEmployeeDto employeeDto)
        {
            //if (!ModelState.IsValid)
            //{
            //    var countries = new List<SelectListItem>
            //{
            //    new SelectListItem { Value = "1", Text = "India" },
            //    new SelectListItem { Value = "2", Text = "France" },
            //    new SelectListItem { Value = "3", Text = "Spain" }
            //};
            //    var states = new List<SelectListItem>
            //{
            //    new SelectListItem { Value = "1", Text = "Delhi" },
            //    new SelectListItem { Value = "2", Text = "Paris" },
            //    new SelectListItem { Value = "3", Text = "Madrid" }
            //};

            //    var cities = new List<SelectListItem>
            //    {
            //        new SelectListItem { Value = "1", Text = "New Delhi" },
            //        new SelectListItem { Value = "2", Text = "Nice" },
            //        new SelectListItem { Value = "3", Text = "Barcelona" }
            //    };

            //    employeeDto.Countries = countries;  
            //    employeeDto.Cities = cities;
            //    employeeDto.States = states;
            //    //return View("AddEmployee", employee); 
            //    return View(employeeDto); 
            //}
           
            var res = await _employeeService.AddEmployeeAsync(employeeDto);

            if (res == null)
            {
                return View("NotFoundData"); 
            }

            return RedirectToAction("Index"); 
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
