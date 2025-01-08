namespace ProductManagment.Models
{
    public class Product
    {
        
          public  Guid ProductId { get; set; }
        public string ProdcutName { get; set; }
        public int CategoryId { get; set; }
        public bool isActive { get; set; } = true;

        public virtual Category? Category { get; set; }

        public virtual  List<ProductOrder> ProductOrders { get; set; }

    }
}
