using FluentAssertions;
using MyProject.Core.Interfaces;
using MyProject.Core.Manager;
using NUnit.Framework;
using System;
using System.Linq;

namespace MyProject.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("User1", "User1Name", "User1Address")]
        [TestCase("User2", "User2Name", null)]
        public void Should_create_customer(string firstName, string lastName, string address)
        {
            //Arrange
            ICustomerManager customerManager = new CustomerManager();

            //Act
            var result = customerManager.CreateCustomer(firstName, lastName, address);

            //Assert
            result.Should().NotBeNull();
            result.FirstName.Should().Be(firstName);
            result.LastName.Should().Be(lastName);
            result.Address.Should().Be(address);
        }

        [Test]
        [TestCase("User1", null, "User1Address")]
        [TestCase(null, "User1Name", "User1Address")]
        [TestCase("User1", "User1Name", "     ")]
        [TestCase("", "User1Name", null)]
        [TestCase("User1", "  ", null)]
        public void Should_not_create_customer_if_null_argument(string firstName, string lastName, string address)
        {
            //Arrange
            ICustomerManager customerManager = new CustomerManager();

            //Act
            Action action = () => customerManager.CreateCustomer(firstName, lastName, address);

            //Assert
            if(string.IsNullOrWhiteSpace(firstName))
                action.Should().Throw<ArgumentNullException>().WithMessage("Your argument should not be empty or null").WithParameterName("firstName");
            else if(string.IsNullOrWhiteSpace(lastName))
                action.Should().Throw<ArgumentNullException>().WithMessage("Your argument should not be empty or null").WithParameterName("lastName");
            else if(address != null && string.IsNullOrWhiteSpace(address))
                action.Should().Throw<ArgumentNullException>().WithMessage("Your argument should not be empty").WithParameterName("address");
        }

        [Test]
        [TestCase("User1", "User1Name", "User1Address")]
        [TestCase("User2", "User2Name", null)]
        public void After_customer_creation_could_search_by_id(string firstName, string lastName, string address)
        {
            //Arrange
            ICustomerManager customerManager = new CustomerManager();

            //Act
            var result = customerManager.CreateCustomer(firstName, lastName, address);
            var resultById = customerManager.GetCustomerById(result.Id);

            //Assert
            resultById.Should().NotBeNull();
            resultById.FirstName.Should().Be(firstName);
            resultById.LastName.Should().Be(lastName);
            resultById.Address.Should().Be(address);
        }

        [Test]
        [TestCase("User1", "User1Name", "User1Address")]
        [TestCase("User2", "User2Name", null)]
        public void After_customer_creation_could_search_by_firstName(string firstName, string lastName, string address)
        {
            //Arrange
            ICustomerManager customerManager = new CustomerManager();

            //Act
            var result = customerManager.CreateCustomer(firstName, null, null);
            var resultById = customerManager.GetCustomer();

            //Assert
            resultById.Should().HaveCount(1);
            if(firstName != null)
                resultById.FirstOrDefault().FirstName.Should().Be(firstName);
        }
    }
}