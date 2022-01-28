using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public class Product : BaseData
    {
        public Product(int id, string name, double price, int stock)
            :base(id)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
