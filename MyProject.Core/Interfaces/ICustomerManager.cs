using MyProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Interfaces
{
    public interface ICustomerManager
    {
        public Customer CreateCustomer(string firstName, string lastName, string address = null);
        public List<Customer> GetCustomer(string firstName = null, string lastName = null, string address = null);
        public bool DeleteCustomer(int id);
        public Customer GetCustomerById(int id);
        public List<Customer> GetAllCustomer();
    }
}
