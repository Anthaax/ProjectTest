using MyProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Interfaces
{
    public interface IOrderManager
    {
        public Order CreateOrder(Customer customer);
        public void DeleteOrder(int orderId);
        public List<Order> GetAllOrders();
        public List<Order> GetCustomerOrders(int customerId);
        public List<Order> GetOrdersWhitSpecificProducts(int productId);
        public Order GetOrderById(int orderId);
        public void CreateOrderItemAnInsert(Order order, Product product, int quantity);
    }
}
