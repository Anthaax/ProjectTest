using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Data
{
    public class Customer : BaseData
    {
        public Customer(int id, string firstName, string lastName, string address)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
