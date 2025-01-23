using System.ComponentModel.DataAnnotations;

namespace EcomMvc.Models
{
    public class LoginViewModel
    {
        [Required (ErrorMessage ="UserName is Required")]
        public string UserName { get; set; }


        [Required (ErrorMessage ="Password Is Rquired")]
        public string Password { get; set; }
    }
}
