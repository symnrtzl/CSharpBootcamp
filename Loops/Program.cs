using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampı";
            string kurs2 = "Programlamaya Giris";


            //arrayler - diziler
            string[] kurslar= new string [] { "Yazilim Gelistirici Yetistirme Kampı", "Programlamaya Giris", "Java" };
            //normalde şu şekil oluyor --> string[] kurslar= kurslarıGetir();

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }





            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}