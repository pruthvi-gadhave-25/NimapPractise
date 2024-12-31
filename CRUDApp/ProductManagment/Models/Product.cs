using Microsoft.EntityFrameworkCore;

namespace ProductManagment.Models
{
    public class Product
    {
        
          public  Guid Id { get; set; }
        public string ProdcutName { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }  
    }
}
