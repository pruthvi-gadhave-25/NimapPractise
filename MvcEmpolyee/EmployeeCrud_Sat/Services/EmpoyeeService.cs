using EmployeeCrud_Sat.Data;
using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud_Sat.Services
{
    public class EmpoyeeService : IEmployeeService
    {   

        private readonly AppDbContext _appDbContext;

        public EmpoyeeService(AppDbContext context)
        {
            _appDbContext = context;
        }


        public async Task<AddEmployeeDto> AddEmployeeAsync(Employee employee)
        {
           var result  =   _appDbContext.Employees.Add(employee);
           await  _appDbContext.SaveChangesAsync();
           if(result != null)
            {
                return employee;
            }
            return null;
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var emp = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId ==  id);

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
            var employees = await _appDbContext.Employees
                .Include(e => e.Country)
                .Include(e =>e.State)
                .Include(e => e.City)
                .ToListAsync(); 
            if(employees == null || employees.Count <= 0 )
            {
                return new List<GetEmployeeDto>();
            }

            var newEmployees = employees.Select(e => new GetEmployeeDto
            {
                EmployeeCode = e.EmployeeCode,
                FirstName = e.FirstName,
                LastName = e.LastName,
                CountryName = e.Country?.CountryName,  
                StateName = e.State?.Name,                    
                CityName = e.City?.Name,                      
                EmailAddress = e.EmailAddress,
                MobileNumber = e.MobileNumber,
                PanNumber = e.PanNumber,
                PassportNumber = e.PassportNumber,
                ProfileImage = e.ProfileImage,
                Gender = e.Gender,
                DateOfBirth = e.DateOfBirth,
                DateOfJoinee = e.DateOfJoinee,
                CreatedDate = e.CreatedDate,
                UpdatedDate = e.UpdatedDate
            }).ToList();

            return newEmployees;
        }

        public async Task<GetEmployeeDto> GetEmployeeByIdAsync(int id)
        {
            var employee = await _appDbContext.Employees.FirstOrDefaultAsync(p => p.EmployeeId == id);

            if(employee == null)
            {
                return null;
            }
            return employee;
        }

        public async  Task<bool> UpdateEmployeeAsync(Employee employee)
        {

         var res =    _appDbContext.Employees.Update(employee);
            await _appDbContext.SaveChangesAsync();
            if(res == null)
            {
                return false;
            }
            return true;

        }
    }
}
