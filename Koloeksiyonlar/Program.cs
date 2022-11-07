using System;
using System.Collections.Generic;

namespace Koloeksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] isimler = new string[] { "Engin", "Murat", "kerem", "halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4] = "ebru";
            //Console.WriteLine(isimler[4]);
            ////patlar çünkü dizi 4 kişiliktir sen sınır dışında bi eleman eklemeye çalışıyorsun

            //isimler = new string[5];
            ////new ile 5 kişilk yeni bir dizi oluşturduk yeni bir adres oluşturduk
            //Console.WriteLine(isimler[4]);
            ////bu sefer ebruyu yazar ama yukarıdaki belirttimi zdizi elemanları uçtu
            
            
            //crtl+k + ctrl+c yaparsak comente alır  //ctrl+k +ctrl+u  comentten çık
            List<string> isimler2 = new List<String> { "Engin", "Murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ebru");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //koleksiyonlar bize mevcut olan kümeye tekrardan eleman sınır aşımı olmaksızın eleman ekleme olanağı sağlarken
            //önceki mevcut elemanların kaybolmasını önlemiş olur
            //sonradan eklemeli kümeler için kullanılır
        }
    }
}
