using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslemOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            Toplama t = new Toplama();
            t.islem(sayi1, sayi2);
            Console.WriteLine(t.IsimGetir()+"---->" +sayi1 +" "+ t.IsaretGetir() +" "+ sayi2 + " = "+ t.Hesapla());
            

            Cıkarma c = new Cıkarma();
            c.islem(sayi1, sayi2 );
            Console.WriteLine(c.IsimGetir() + " işleminin sonucu " + c.Hesapla());



            Console.ReadLine();
        }
    }
}
