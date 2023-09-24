using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1=new Product();
            product1.Name = "Elma";
            product1.Description = "Amasya Elması";
            product1.Price = 10;

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Description = "Diyarbakır Karpuzu";
            product2.Price = 70;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products) { 
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Price);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("-------------------METOTLAR--------------");
            SepetManager sepetManager = new SepetManager();
            //encapsulation
            sepetManager.Add(product1);
        }
    }
}