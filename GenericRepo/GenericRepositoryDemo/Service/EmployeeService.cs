using GenericRepositoryDemo.Interface;

namespace GenericRepositoryDemo.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _repository;
        
        
        public EmployeeService(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async  Task Add(Employee employee)
        {
           await  _repository.Add(employee);
            Console.WriteLine("\n\n Added succefully \n \n");
        }

        public async Task AddEmployee(Employee employee)
        {
            await _repository.Add(employee);
            await _repository.Save();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
