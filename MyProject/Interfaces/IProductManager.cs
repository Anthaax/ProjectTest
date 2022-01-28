using MyProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Interfaces
{
    public interface IProductManager
    {
        public Product CreateProduct(string name, double price, int stock = 0);
        public Product GetProductById(int productId);
        public List<Product> GetAllProducts();
        public Product GetProductByName(string name);
        public void DeleteProduct(int productId);
    }
}
