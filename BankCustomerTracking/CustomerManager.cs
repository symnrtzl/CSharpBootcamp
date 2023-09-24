using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomerTracking
{
    class CustomerManager
    {
        //Customer[] customers= new Customer[] {};
        List<Customer> customerList= new List<Customer>();
        
        public void GetAllCustomer() {
            foreach (Customer c in customerList)
            {
                Console.WriteLine("Firstname:" + c.FirstName + "    Lastname:" + c.LastName + " Email:" + c.Email + "   Address:" + c.Address);
            }
        } 
        public void AddCustomer(Customer customer) {
            customerList.Add(customer);
            GetAllCustomer();
            Console.WriteLine("------");
        }

        public void DeleteCustomer(Customer customer) {
            customerList.Remove(customer);
            Console.WriteLine("Customer :-" +  customer.FirstName +"- deleted");
            GetAllCustomer();
        }
        

    }
}
