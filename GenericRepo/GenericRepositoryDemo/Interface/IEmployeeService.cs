namespace GenericRepositoryDemo.Interface
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployeeAsync(int id);
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task  AddEmployee(Employee employee);   
    }
}
