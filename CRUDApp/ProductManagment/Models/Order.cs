namespace ProductManagment.Models
{
    public class Order
    {
        public int OrderId {  get; set; }

       public List<ProductOrder> ProductOrders { get; set; }

    }
}
