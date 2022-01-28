using FluentAssertions;
using Moq;
using MyProject.Interfaces;
using MyProject.Manager;
using Xunit;

namespace ProjectTest
{
    public class CustomerTest
    {
        [Theory]
        [InlineData("Guillaume","Fimes","13 Square Charles Laurent")]
        [InlineData("Olivier", "Roussel", null)]
        public void ShouldCreateCustomer(string firstName, string lastName, string address)
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
    }
}