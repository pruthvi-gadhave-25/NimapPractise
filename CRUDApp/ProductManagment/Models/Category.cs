﻿namespace ProductManagment.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


        public bool IsActive { get; set; } = true;



    }
}