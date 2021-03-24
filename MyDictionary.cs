using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<MyKey, MyValue> // MyKey ve MyClass ile çalışır.
    {
        (MyKey, MyValue)[] array;

       
        public MyDictionary()
        {
            array = new (MyKey, MyValue)[0]; 

        }

        
        // myKey --> Müşteri Numarası
        // myValue --> Müşteri İsmi  tutuyor.
      
        public void Add(MyKey customerNo, MyValue customerName)
        {
            // tempArray ile geçiçi dizi oluşturduk. 
            (MyKey, MyValue)[] tempArray = array;
            // new array önceki referans adresindeki değerleri alıp +1 ekleyecek.
            array = new (MyKey, MyValue)[array.Length + 1];
          
            for (int i = 0; i < tempArray.Length; i++) 
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = (customerNo, customerName);
        }
        
        public int Count
        {
            get { return array.Length; }
        }

        
        public void Listeleme()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Müşteri Adı ve Müşteri Numarası: " + array[i]);
            }
        }
    }
}