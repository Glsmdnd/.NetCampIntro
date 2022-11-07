using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        { 
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Burak", 18);
            myDictionary.Add("haydar", 45);

            Console.WriteLine("Eklenen Eleman Sayısı : " + myDictionary.Length);

            Console.WriteLine("Eklenen Elemanlar");
            myDictionary.List();

        }

    }
    
}
