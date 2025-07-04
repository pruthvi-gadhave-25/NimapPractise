using EmployeeCrud_Sat.Data;
using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud_Sat.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly AppDbContext _appDbContext;

        public EmployeeService(AppDbContext context)
        {
            _appDbContext = context;
        }


        public async Task<AddEmployeeDto> AddEmployeeAsync(AddEmployeeDto employee)
        {

            var emp = new Employee
            {
                EmployeeCode = employee.EmployeeCode,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                //CountryName = employee.CountryId,
                //StateName = employee.State?.Name,
                //CityName = employee.City?.Name,
                EmailAddress = employee.EmailAddress,
                MobileNumber = employee.MobileNumber,
                PanNumber = employee.PanNumber,
                PassportNumber = employee.PassportNumber,
                ProfileImage = employee.ProfileImage,
                Gender = employee.Gender,
                DateOfBirth = employee.DateOfBirth,
                DateOfJoinee = employee.DateOfJoinee,
                CreatedDate = employee.CreatedDate,
                UpdatedDate = employee.UpdatedDate
            };
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
            var newEmp = new List<GetEmployeeDto>();           
            try
            {
                     newEmp = new List<GetEmployeeDto>
                {
                     new GetEmployeeDto
                        {
                            EmployeeCode = "EMP001",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            CountryName = "USA",
                            StateName = "California",
                            CityName = "Los Angeles",
                            EmailAddress = "alice.johnson@example.com",
                            MobileNumber = "1234567890",
                            PanNumber = "PAN1234A",
                            PassportNumber = "P1234567",
                            ProfileImage = "alice.jpg",
                            Gender = 1,
                            DateOfBirth = new DateTime(1990, 5, 10),
                            DateOfJoinee = new DateTime(2020, 1, 15),
                            CreatedDate = DateTime.Now.AddMonths(-6),
                            UpdatedDate = DateTime.Now.AddDays(-10)
                        },
                        new GetEmployeeDto
                        {
                            EmployeeCode = "EMP002",
                            FirstName = "Bob",
                            LastName = "Smith",
                            CountryName = "India",
                            StateName = "Maharashtra",
                            CityName = "Mumbai",
                            EmailAddress = "bob.smith@example.com",
                            MobileNumber = "9876543210",
                            PanNumber = "PAN5678B",
                            PassportNumber = "P7654321",
                            ProfileImage = "bob.jpg",
                            Gender = 0,
                            DateOfBirth = new DateTime(1988, 3, 25),
                            DateOfJoinee = new DateTime(2019, 6, 1),
                            CreatedDate = DateTime.Now.AddMonths(-12),
                            UpdatedDate = DateTime.Now.AddDays(-5)
                        },
                };

                return newEmp;
            }
            catch (Exception ex)
            {
                return newEmp;
            }
        }

        public async Task<GetEmployeeDto> GetEmployeeByIdAsync(int id)
        {
            var employee = await _appDbContext.Employees
                 .Include(e => e.Country)
                .Include(e => e.State)
                .Include(e => e.City)
                .FirstOrDefaultAsync(p => p.EmployeeId == id);

            if (employee == null)
            {
                return null;
            }
            var newEmployee = new GetEmployeeDto
            {
                EmployeeCode = employee.EmployeeCode,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                CountryName = employee.Country?.CountryName,
                StateName = employee.State?.Name,
                CityName = employee.City?.Name,
                EmailAddress = employee.EmailAddress,
                MobileNumber = employee.MobileNumber,
                PanNumber = employee.PanNumber,
                PassportNumber = employee.PassportNumber,
                ProfileImage = employee.ProfileImage,
                Gender = employee.Gender,
                DateOfBirth = employee.DateOfBirth,
                DateOfJoinee = employee.DateOfJoinee,
                CreatedDate = employee.CreatedDate,
                UpdatedDate = employee.UpdatedDate
            };

            return newEmployee;
        }

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {

            var res = _appDbContext.Employees.Update(employee);
            await _appDbContext.SaveChangesAsync();
            if (res == null)
            {
                return false;
            }
            return true;

        }
    }
}
