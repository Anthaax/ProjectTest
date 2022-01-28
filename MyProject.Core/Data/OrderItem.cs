using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Data
{
    public class OrderItem
    {
        public OrderItem(Product prodcut, int quantity, double amount)
        {
            Product = prodcut;
            Quantity = quantity;
            Amount = amount;
        }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double Amount { get; set; }
    }
}
