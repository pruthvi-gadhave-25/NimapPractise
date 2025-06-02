using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]

        public string Position { get; set; }
    }
}
