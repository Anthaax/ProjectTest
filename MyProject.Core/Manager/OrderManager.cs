using MyProject.Core.Data;
using MyProject.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Manager
{
    public class OrderManager : IOrderManager
    {
        readonly IPriceManager _priceManager;
        readonly List<Order> _orders;
        public OrderManager(IPriceManager priceManager)
        {
            _priceManager = priceManager;
            _orders = new List<Order>();
        }
        public Order CreateOrder(Customer customer)
        {
            if (customer == null) throw new ArgumentNullException("customer", "customer can't be null");
            Order order = new Order(_orders.Count, customer);
            _orders.Add(order);
            return _orders[order.Id];
        }

        public void CreateOrderItemAnInsert(Order order, Product product, int quantity)
        {
            if (order == null) throw new ArgumentNullException("order");
            if (product == null) throw new ArgumentNullException("product");
            if (quantity < 1) throw new ArgumentException("quantity", "quantity can't be negative or 0");

            if(quantity > product.Stock) 
                quantity = product.Stock;
            OrderItem orderItem = new OrderItem(product, quantity, product.Price * quantity);
            order.Items.Add(orderItem);
            product.UpdateStock(quantity, false);
            order.CalculateTotalAmount();
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
