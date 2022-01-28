using MyProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public class OrderItem : BaseData
    {
        public OrderItem(int id, Product prodcut, int quantity, double amount)
            :base(id)
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
