using System;

namespace BankCustomerTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1,"Selim","Selim","Istanbul","selim@gmail.com");
            Customer customer2 = new Customer(1, "Ayca", "Kara", "Istanbul", "ayca@gmail.com");
            Customer customer3 = new Customer(1, "Pelin", "Derin", "Istanbul", "pelin@gmail.com");
            Customer customer4 = new Customer(1, "Mustafa", "Duru", "Istanbul", "mustafa@gmail.com");
            Customer customer5 = new Customer(1, "Mahmut", "Can", "Istanbul", "mahmut@gmail.com");
            Customer customer6 = new Customer(1, "Derya", "Cam", "Istanbul", "derya@gmail.com");
            Customer customer7 = new Customer(1, "Hakan", "Selim", "Istanbul", "hakan@gmail.com");
            Customer customer8 = new Customer(1, "Mert", "Yılmaz", "Istanbul", "mert@gmail.com");


            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] {customer1, customer2, customer3, customer4, customer5, customer6, customer7, customer8};

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);

            customerManager.DeleteCustomer(customer1);

            customerManager.GetAllCustomer();
        }
    }
}