﻿namespace ProductManagment.Models
{
    public class ProductOrder
    {
        public int ProductOrderId {  get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public Product Product { get; set; } = null;
        public Order Order { get; set; } = null;
    }
}