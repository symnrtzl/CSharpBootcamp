using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomerTracking
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Customer()
        {
        }

        public Customer(int ıd, string firstName, string lastName, string address, string email)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
        }



    }
}
