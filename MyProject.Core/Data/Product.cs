using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Data
{
    public class Product : BaseData
    {
        public Product(int id, string name, double price, int stock)
            : base(id)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public string Name { get; }
        public double Price { get; }
        public int Stock { get; private set; }

        public void UpdateStock(int quantity, bool toAdd)
        {
            if (toAdd)
                Stock += quantity;
            else
                Stock -= quantity;
        }
    }
}
