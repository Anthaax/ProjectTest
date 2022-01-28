using MyProject.Core.Data;
using MyProject.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Manager
{
    public class ProductManager : IProductManager
    {
        public Product CreateProduct(string name, double price, int stock = 0)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
