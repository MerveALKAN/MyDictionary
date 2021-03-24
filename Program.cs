using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary

            Console.WriteLine("------- Dictionary --------");

            Dictionary<string, int> musteriler = new Dictionary<string, int>();
            musteriler.Add("Sinem", 7777); 
            Console.WriteLine("Müşteri Sayısı : " + musteriler.Count); 

  
            Console.WriteLine("-------- MyDictionary --------");


            // MyDictionary
            MyDictionary<string, int> musteriler2 = new MyDictionary<string, int>();
            musteriler2.Add("Merve", 2585);
            musteriler2.Add("Aylin", 3362);
            musteriler2.Add("Nilgün", 1122);
            Console.WriteLine("Müşteri sayısı : " + musteriler2.Count);
            musteriler2.Listeleme();

           

        }
    }
}