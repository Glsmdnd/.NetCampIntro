using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği 
            //Do not repeat yourself-kendini tekrarlama
            //deger tutucu
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;
            if(dolarDun<dolarBugun)
            {
                Console.WriteLine("zararda");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("karda");
            }
            else
            {
                Console.WriteLine("Denk");
            }

            Console.WriteLine(kategoriEtiketi);
            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
