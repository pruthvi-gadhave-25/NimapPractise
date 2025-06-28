namespace EmployeeCrud_Sat.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string Name { get; set; }
        public Country? Country { get; set; }

        public int CountryId { get; set; }


        public List<City>? Cities { get; set; }
        public List<Employee>? Employees{ get; set; }

    }
}
