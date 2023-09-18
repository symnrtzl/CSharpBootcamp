using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1=new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 10;

            Product product2= new Product { Id = 2,UnitsInStock = 10,
                CategoryId=2, UnitPrice=100, ProductName="Kalem"};

            //stack                          //heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}