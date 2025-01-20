using System.ComponentModel.DataAnnotations;

namespace EcomMvc.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public required string ProdcutName { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual Category? Category { get; set; }

    }
}
