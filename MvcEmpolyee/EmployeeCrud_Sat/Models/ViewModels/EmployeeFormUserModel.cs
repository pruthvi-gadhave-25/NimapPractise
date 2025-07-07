namespace EmployeeCrud_Sat.Models.ViewModels
{
    public class EmployeeFormUserModel
    {
        public int  StateId { get; set; }

        public IEnumerable<State> State { get; set; }  = new List<State>();
    }
}
