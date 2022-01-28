using MyProject.Data;
using MyProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Manager
{
    public class CustomerManager : ICustomerManager
    {
        public Customer CreateCustomer(string firstName, string lastName, string? address = null)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomer(string? firstName = null, string? lastName = null, string? address = null)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
