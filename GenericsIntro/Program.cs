using System;
using System.Xml;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] strings)
        {
            MyList<String> isimler = new MyList<string>();
            isimler.Add("Selim");
            isimler.Add("Selin");
            Console.WriteLine(isimler.Length);
            isimler.Add("Kaan");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items) {
                Console.WriteLine(isim);
            }
        }
    }
}