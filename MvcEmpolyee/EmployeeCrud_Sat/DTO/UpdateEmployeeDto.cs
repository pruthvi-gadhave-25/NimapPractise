using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud_Sat.DTO
{
    public class UpdateEmployeeDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
