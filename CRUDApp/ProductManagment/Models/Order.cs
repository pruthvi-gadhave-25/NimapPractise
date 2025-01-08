namespace ProductManagment.Models
{
    public class Order
    {
        public int OrderId {  get; set; }

       public virtual  List<ProductOrder> ProductOrders { get; set; }

    }
}
