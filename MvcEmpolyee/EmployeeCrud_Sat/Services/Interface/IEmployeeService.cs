using EmployeeCrud_Sat.Models;

namespace EmployeeCrud_Sat.Services.Interface
{
    public interface IEmployeeService 
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeByIdAsync(int id);

        Task<Employee> AddEmployeeAsync(Employee employee);
      
        Task<bool> UpdateEmployeeAsync(Employee employee);
   
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
