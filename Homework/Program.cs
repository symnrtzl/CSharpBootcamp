using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Monster Abra A7", "Bu ürün Monster Notebook tarafından gönderilecektir.", "Bilgisayar", 27.299);
            Product product2 = new Product(2, "ASUS Tuf Gaming", "Bu ürün ASUS tarafından gönderilecektir.", "Bilgisayar", 37.899);
            Product product3 = new Product(3, "Samsung Galaxy A34", "Bu ürün Samsung tarafından gönderilecektir.", "Telefon", 10.969);
            Product product4 = new Product(4, "Nikon D3500 Kamera", "Bu ürün Nicon tarafından gönderilecektir.", "Kamera", 17.599);
            Product product5 = new Product(5, "Daniel Klein Metalik Çelik Bilezik Kadın Kol Saati", "Bu ürün Daniel Klein tarafından gönderilecektir.", "Saat", 1.299);
            Product product6 = new Product(6, "Bosch Kgn76cıe0n Serie 6 Alttan Donduruculu Buzdolabı", "Bu ürün Bosch tarafından gönderilecektir.", "Buzdolabı", 33.499);
            Product product7 = new Product(7, "LENOVO Lp1 Livepods Kablosuz Bluetooth Kulaklık", "Bu ürün Lenovo tarafından gönderilecektir.", "Kulaklık", 314);

            Product[] products = new Product[] { product1, product2, product3, product4, product5, product6, product7 };



            Console.WriteLine("FOREACH");
            foreach (var product in products) {
                Console.WriteLine("Category : " + product.Category +"\nName : " + product.Name + "\nDescription :" + product.Description + "\nPrice :" + product.Price);
                Console.WriteLine("-----------------");
            }





            Console.WriteLine("WHILE LOOP");
            int i= 0;
            while (i<products.Length)
            {
                Console.WriteLine("Category : " + products[i].Category + "\nName : " + products[i].Name + "\nDescription :" + products[i].Description + "\nPrice :" + products[i].Price);
                Console.WriteLine("-----------------");
                i++;
            }
        }

        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }

            public double Price { get; set; }

            public Product()
            {
            }

            public Product(int ıd, string name, string description, string category, double price)
            {
                Id = ıd;
                Name = name;
                Description = description;
                Category = category;
                Price = price;
            }
        }
    }
}