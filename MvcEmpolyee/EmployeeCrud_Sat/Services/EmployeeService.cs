using EmployeeCrud_Sat.Data;
using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Models.ViewModels;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace EmployeeCrud_Sat.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EmployeeService(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = context;
            _webHostEnvironment = webHostEnvironment;
        }

        private async  Task<string> GetRandId()
        {
            string str = "";
            Random rand = new Random();

            int randValue = rand.Next(0, 26);

            // Generating random character by converting
            // the random number into character.
            char letter = Convert.ToChar(randValue + 65);

            // Appending the letter to string.
            str = str + letter;

            return str;
        }

        public async Task<AddEmployeeDto> AddEmployeeAsync(AddEmployeeDto employee)
        {

            var emp = new Employee
            {
                EmployeeCode = await GetRandId(),
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                CountryId = employee.CountryId,
                StateId = employee.StateId,
                CityId = employee.CountryId,
                EmailAddress = employee.EmailAddress,
                MobileNumber = employee.MobileNumber,
                PanNumber = employee.PanNumber,
                PassportNumber = employee.PassportNumber,
                Gender = employee.Gender,
                DateOfBirth = employee.DateOfBirth,
                DateOfJoinee = employee.DateOfJoinee,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                IsActive =false 
            };

            if(employee.ProfileImage != null  && employee.ProfileImage.Length > 0)
            {
                
                string path = Path.Combine(_webHostEnvironment.WebRootPath ,  "uploads" ,"employee-images");
                Directory.CreateDirectory(path);

                string fileName = new Guid() + Path.GetExtension(employee.ProfileImage.FileName);
                string filepaht = Path.Combine(path, fileName);

                using (  var stream  =  new FileStream(filepaht, FileMode.Create))
                {
                    await employee.ProfileImage.CopyToAsync(stream);

                }

                // Store relative path in DB (so you can use it in <img>)
                emp.ProfileImage = Path.Combine("uploads/employee-images", fileName).Replace("\\", "/");
            }
            var result = _appDbContext.Employees.Add(emp);
            await _appDbContext.SaveChangesAsync();
            if (result != null)
            {
                return employee;
            }
            return null;
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var emp = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);

            if (emp == null)
            {
                return false;
            }
            var res = _appDbContext.Employees.Remove(emp);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<GetEmployeeDto>> GetAllEmployees()
        {
                    
            try
            {             
                var res = await  _appDbContext.Employees.Select(e => new GetEmployeeDto
                {
                    Id =  e.EmployeeId,
                    EmailAddress = e.EmailAddress,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    PanNumber = e.PanNumber,
                    CountryName = e.Country.CountryName ?? " ",
                    Gender = e.Gender ==  0 ? "Male" : "Female",
                    DateOfBirth = e.DateOfBirth.ToString("MM/dd/yyyy"),
                    DateOfJoinee = e.DateOfJoinee.HasValue ?  e.DateOfJoinee.Value.ToString("MM/dd/yyyy"): null
                }).ToListAsync();
                              
                return res ?? new List<GetEmployeeDto>();
            }
            catch (Exception ex)
            {
                return new List<GetEmployeeDto>();
            }
        }

        public async Task<GetEmployeeDto> GetEmployeeByIdAsync(int id)
        {

            var employee = await _appDbContext.Employees.Select( e => new GetEmployeeDto
            {   
                Id =e.EmployeeId,
                EmployeeCode = e.EmployeeCode,
                FirstName = e.FirstName,
                LastName = e.LastName,
                CountryId =  e.CountryId,
                StateId = e.StateId,
                CityId = e.CityId,
                EmailAddress = e.EmailAddress,
                MobileNumber = e.MobileNumber,
                PanNumber = e.PanNumber,
                PassportNumber = e.PassportNumber,
                ProfileImage = e.ProfileImage,
                Gender = Convert.ToString(e.Gender),
                DateOfBirth = e.DateOfBirth.ToString("yyyy-MM-dd"),
            }).FirstOrDefaultAsync(  e => e.Id == id);   
                

            if (employee == null)
            {
                return null;
            }         
            return employee;
        }

        public async Task<bool> UpdateEmployeeAsync(EditEmployeeDto employeeDto)
        {


            try
            {
                var employee = new Employee
                {
                    EmployeeId = employeeDto.Id,
                    EmployeeCode = employeeDto.EmployeeCode,
                    FirstName = employeeDto.FirstName,
                    LastName = employeeDto.LastName,
                    CountryId = employeeDto.CountryId,
                    StateId = employeeDto.StateId,
                    CityId = employeeDto.CityId,
                    EmailAddress = employeeDto.EmailAddress,
                    MobileNumber = employeeDto.MobileNumber,
                    PanNumber = employeeDto.PanNumber,
                    PassportNumber = employeeDto.PassportNumber,
                    ProfileImage = employeeDto.ProfileImage,
                    Gender = employeeDto.Gender,
                    IsActive = true,
                    DateOfBirth = DateTime.Parse(employeeDto.DateOfBirth),
                    DateOfJoinee = string.IsNullOrWhiteSpace(employeeDto.DateOfJoinee) ? null : DateTime.Parse(employeeDto.DateOfJoinee),
                    CreatedDate = DateTime.UtcNow
                };

                var res = _appDbContext.Employees.Update(employee);
                await _appDbContext.SaveChangesAsync();

                return res != null;
            }
            catch (Exception ex)
            {
                // Log this or inspect in debugger
                Console.WriteLine("Exception occurred: " + ex.Message);
                throw; // or return false, depending on design
            }

        }
    }
}
