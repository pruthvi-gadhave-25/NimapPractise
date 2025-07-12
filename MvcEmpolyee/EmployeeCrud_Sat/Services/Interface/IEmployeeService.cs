using EmployeeCrud_Sat.Data;
using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Models.ViewModels;

namespace EmployeeCrud_Sat.Services.Interface
{
    public interface IEmployeeService 
    {
        Task<List<GetEmployeeDto>> GetAllEmployees();
        Task<GetEmployeeDto> GetEmployeeByIdAsync(int id);

        Task<AddEmployeeDto> AddEmployeeAsync(AddEmployeeDto employee);
      
        Task<bool> UpdateEmployeeAsync(EditEmployeeDto employee);
   
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
