namespace EmployeeCrud_Sat.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public State? State { get; set; }

        public List<Employee>? Employees { get; set; }
    }
}
