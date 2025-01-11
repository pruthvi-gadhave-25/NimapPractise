using System.ComponentModel.DataAnnotations;
namespace DemoMvc.Models
{
    public class Student
    {   
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string? Name { get; set; }


        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Phone No. is Required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone No. must be exactly 10 digits.")]
        public string Phone { get; set; }


        public bool Subscribed { get; set; }
      

        //public IFormFile? Photo { get; set; }

    }
}
