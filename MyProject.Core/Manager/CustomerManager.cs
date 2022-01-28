using MyProject.Core.Data;
using MyProject.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Manager
{
    public class CustomerManager : ICustomerManager
    {
        public Customer CreateCustomer(string firstName, string lastName, string address = null)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomer(string firstName = null, string lastName = null, string address = null)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
