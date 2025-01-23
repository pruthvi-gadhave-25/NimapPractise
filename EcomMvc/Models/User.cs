using System.ComponentModel.DataAnnotations;
namespace EcomMvc.Models
{
    public class User
    {
           
        public int UserId { get; set; }

        [Required(ErrorMessage = "USername is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string? Role { get; set; }
    }
}
