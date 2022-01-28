using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Core.Interfaces;
using Moq;
using MyProject.Core.Data;
using MyProject.Core.Manager;

namespace MyProject.Tests
{
    [TestFixture]
    public class OrderTest
    {
        Mock<ICustomerManager> _customerManagerMock;
        Mock<IProductManager> _productMangerMock;
        Mock<IPriceManager> _priceManagerMock;
        Mock<IOrderManager> _orderManagerMock;

        [SetUp]
        public void Setup()
        {
            _customerManagerMock = new Mock<ICustomerManager>();
            _productMangerMock = new Mock<IProductManager>();
            _priceManagerMock = new Mock<IPriceManager>();
            _orderManagerMock = new Mock<IOrderManager>();

            _customerManagerMock.Setup(x => x.GetCustomerById(It.IsAny<int>())).Returns(new Customer(0, "UnitTestFirstName", "unitTestLastName", "UnitTestAddress"));
            _productMangerMock.Setup(x => x.GetProductById(It.IsAny<int>())).Returns(new Product(0, "UnitTestName", 10, 20));
            _orderManagerMock.Setup(x => x.GetOrderById(It.IsAny<int>())).Returns(new Order(0, _customerManagerMock.Object.GetCustomerById(0)));
        }

        [Test]
        public void Should_Create_Order()
        {
            //Arrange
            IOrderManager orderManager = new OrderManager(_priceManagerMock.Object);
            Customer customer = _customerManagerMock.Object.GetCustomerById(0);

            //Act
            Order result = orderManager.CreateOrder(customer);

            //Assert
            result.Should().NotBeNull();
            result.Customer.Should().NotBeNull();
            result.Customer.FirstName.Should().Be(customer.FirstName);
            result.Customer.LastName.Should().Be(customer.LastName);
            result.Items.Should().NotBeNull();
        }

        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(1)]
        [TestCase(12)]
        public void should_add_orderItem_inferior_quantity_than_product_stock(int quantity)
        {
            //Arrange
            IOrderManager orderManager = new OrderManager(_priceManagerMock.Object);
            Order order = _orderManagerMock.Object.GetOrderById(0);
            Product product = _productMangerMock.Object.GetProductById(0);
            int originalStock = product.Stock;

            //Act
            orderManager.CreateOrderItemAnInsert(order, product, quantity);

            //Assert
            order.Items.Should().HaveCount(1);
            order.Items[0].Quantity.Should().Be(quantity);
            order.Items[0].Product.Name.Should().Be(product.Name);
            product.Stock.Should().Be(originalStock - quantity);
        }

        [Test]
        [TestCase(12543)]
        [TestCase(int.MaxValue)]
        [TestCase(164136)]
        [TestCase(68596)]
        public void should_add_orderItem_superior_quantity_than_stock(int quantity)
        {
            //Arrange
            IOrderManager orderManager = new OrderManager(_priceManagerMock.Object);
            Order order = _orderManagerMock.Object.GetOrderById(0);
            Product product = _productMangerMock.Object.GetProductById(0);
            int originalStock = product.Stock;

            //Act
            orderManager.CreateOrderItemAnInsert(order, product, quantity);

            //Assert
            order.Items.Should().HaveCount(1);
            order.Items[0].Quantity.Should().Be(originalStock);
            order.Items[0].Product.Name.Should().Be(product.Name);
            product.Stock.Should().Be(0);
        }

        [Test]
        [TestCase(-12543)]
        [TestCase(int.MinValue)]
        [TestCase(-1)]
        [TestCase(0)]
        public void should_add_orderItem_negativ_quantity(int quantity)
        {
            //Arrange
            IOrderManager orderManager = new OrderManager(_priceManagerMock.Object);
            Order order = _orderManagerMock.Object.GetOrderById(0);
            Product product = _productMangerMock.Object.GetProductById(0);
            int originalStock = product.Stock;

            //Act
            Action action = () => orderManager.CreateOrderItemAnInsert(order, product, quantity);

            //Assert
            action.Should().Throw<ArgumentException>();
            product.Stock.Should().Be(originalStock);
            order.Items.Should().HaveCount(0);
        }
    }
}
