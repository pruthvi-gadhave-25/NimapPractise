namespace EmployeeCrud_Sat.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public List<State>? States { get; set; }
        public List<Employee>? employees { get; set; } = new List<Employee>();
    }
}
