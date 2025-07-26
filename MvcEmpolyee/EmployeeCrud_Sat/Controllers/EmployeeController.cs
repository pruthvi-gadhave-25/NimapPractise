using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Models.ViewModels;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            catch (Exception ex)
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

            ModelState.Remove("States");
            ModelState.Remove("Countries");
            ModelState.Remove("Cities");
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                     .Where(x => x.Value.Errors.Count > 0)
                     .Select(x => new
                     {
                         Field = x.Key,
                         Errors = x.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                     }).ToList();


                Console.WriteLine(employeeDto);
                return BadRequest();
            }

            var res = await _employeeService.AddEmployeeAsync(employeeDto);

            if (res == null)
            {
                return View("NotFoundData");
            }

            return RedirectToAction("Index");
        }




        public async Task<IActionResult> EditEmployee(int id)
        {

            try
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

                var emp = await _employeeService.GetEmployeeByIdAsync(id);

                var editDtp = new EditEmployeeDto
                {
                    EmployeeId = emp.EmployeeId,
                    EmployeeCode = emp.EmployeeCode,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    CountryId = emp.CountryId,
                    StateId = emp.StateId,
                    CityId = emp.CityId,
                    EmailAddress = emp.EmailAddress,
                    MobileNumber = emp.MobileNumber,
                    PanNumber = emp.PanNumber,
                    PassportNumber = emp.PassportNumber,
                    ProfileImage = emp.ProfileImage,
                    Gender = (byte)(emp.Gender == "Male" ? 1 : 0),
                    DateOfBirth = emp.DateOfBirth,
                    DateOfJoinee = emp.DateOfJoinee,
                    Countries = countries,
                    States = states,
                    Cities = cities,
                };
                //ViewData["EmployeeCode"] = emp.EmployeeCode;

                if (emp == null) return NotFound();

                return View("EditEmployee", editDtp);

                //return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("NotFound");
            }
        }


        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(EditEmployeeDto employeeDto)
        {

            ModelState.Remove("States");
            ModelState.Remove("Countries");
            ModelState.Remove("Cities");

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

            employeeDto.CityName = cities.FirstOrDefault(v => v.Value == employeeDto.CityId.ToString())?.Text;
            employeeDto.StateName = states.FirstOrDefault(v => v.Value == employeeDto.StateId.ToString())?.Text;
            employeeDto.CountryName = countries.FirstOrDefault(v => v.Value == employeeDto.CountryId.ToString())?.Text;

            if (!ModelState.IsValid)
            {
                var errors = ModelState
                     .Where(x => x.Value.Errors.Count > 0)
                     .Select(x => new
                     {
                         Field = x.Key,
                         Errors = x.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                     }).ToList();


                Console.WriteLine(employeeDto);
                return BadRequest();
            }

            var res = await _employeeService.UpdateEmployeeAsync(employeeDto);

            if (res == null)
            {
                return View("NotFoundData");
            }

            return RedirectToAction("Index");
        }


        // GET: Delete Confirmation
        public async Task<IActionResult> Delete(int id)
        {

            var employee =  _employeeService.GetEmployeeByIdAsync(id);


            //var todoItem = await _context.TodoItems.FirstOrDefaultAsync(m => m.Id == id);
            //if (todoItem == null)
            //{
            //    return NotFound();
            //}

            //return View(todoItem);
            return View(employee);
        }

        // POST: Delete the Item
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            if (id != null)
            {
               await  _employeeService.DeleteEmployeeAsync(id);                
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
