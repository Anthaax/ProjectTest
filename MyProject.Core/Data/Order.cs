using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Data
{
    public class Order : BaseData
    {
        public Order(int id, Customer customer)
            : base(id)
        {
            Customer = customer;
            Items = new List<OrderItem>();
        }
        public List<OrderItem> Items { get; private set; }
        public Customer Customer { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public void CalculateTotalAmount()
        {
            Total = 0;
            foreach (var item in Items)
            {
                Total += item.Amount;
            }
        }
    }
}
