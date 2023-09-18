using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Engin","Murat"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            isimler.Add("İlker");
            Console.WriteLine(isimler[2]);


        }
    }
}