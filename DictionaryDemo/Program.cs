using System;
using System.Collections.Generic;
using System.Xml;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] strings)
        {
            Dictionary<String,String> dictionarys = new Dictionary<String, String>();
            dictionarys.Add("Selim", "Selim");
            dictionarys.Add("Pelin", "Kaya");
            Console.WriteLine(dictionarys.ValuesLength);

            dictionarys.Add("Kaan", "Kurt");
            dictionarys.Add("Ali", "Dere");
            Console.WriteLine(dictionarys.ValuesLength);

            foreach (var dictionary in dictionarys.Keys)
            {
                Console.WriteLine(dictionary);
            }

            foreach (var dictionary in dictionarys.Values)
            {
                Console.WriteLine(dictionary);
            }

        }
    }
}