using MyProject.Data;
using MyProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Manager
{
    public class OrderManager : IOrderManager
    {
        readonly IPriceManager _priceManager;
        public OrderManager(IPriceManager priceManager)
        {
            _priceManager = priceManager;
        }
        public Order CreateOrder(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void CreateOrderItemAnInsert(Order order, Product product, int quantity)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetCustomerOrders(int customerId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersWhitSpecificProducts(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
