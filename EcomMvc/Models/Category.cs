using System.ComponentModel.DataAnnotations;

namespace EcomMvc.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string? CategoryName { get; set; }
        public bool? IsActive { get; set; } = true;
    }
   
}
