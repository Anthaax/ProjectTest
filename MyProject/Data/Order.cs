using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public class Order : BaseData
    {
        public Order(int id, Customer customer)
            :base(id)
        {
            Customer = customer;
            Items = new List<OrderItem>();
        }
        public List<OrderItem> Items { get; private set; }
        public Customer Customer { get; set; }
        public double Discount { get; set; }
        public double Total { get;set; }
    }
}
