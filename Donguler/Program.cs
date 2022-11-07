using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılımcı Geliştirme Kampı";
            //string kurs2 = "Programlamaya Başlangıç";
            //string kurs3 = "Java";
            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);

            //int[] sayilar = new int[] {5,7,11};
            string[] kurslar = new string[] { "Yazılımcı Geliştirme Kampı", "Programlamaya Başlangıç", "java" };
            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}
            //Console.WriteLine("For Sonu");


            //foreach tamamen dizi dönmek için tasarlanan bir döngü
            foreach (String kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        

            
        }
    }
}
