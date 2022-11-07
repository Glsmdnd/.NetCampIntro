using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //bu kişi gerçekmi tüzelmi  bu iki nesne birbirine benziyor diye birbirlerinin yerine kullanılamazlar
            //farklı müsteri tipleridir.Birb yerine asla kullanılamazlar
            //musteri1.Tipi=1 ise gerçek değilse tüzel bu da çok yalnış bir kullanımdır.
            //SOLİD birbirine benziyor diye inheritance yapma

            GercekMusteri gercekMusteri1 = new GercekMusteri();//gerçek musteri Gülsüm Döndü olsun
            gercekMusteri1.ID = 1;//musteri sınıfından inherite edildi
            gercekMusteri1.MusteriNo = "52";//musteri sınıfından inherite edildi
            gercekMusteri1.TcNo = "456852";
            gercekMusteri1.Adi = "Gülsüm";
            gercekMusteri1.Soyadi = "Döndü";

            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();//tuzel musterim kodlama io firması olsun
            tuzelMusteri1.ID = 2;//musteri sınıfından inherite edildi
            tuzelMusteri1.MusteriNo = "21";//musteri sınıfından inherite edildi
            tuzelMusteri1.SirketAdi = "kodlama.io";
            tuzelMusteri1.VergiNo = "879";

            Musteri musteri3 = new GercekMusteri();//musteri clası hem gercek hem tuzel clasların referanslarını tutabilir.
            Musteri musteri4 = new TuzelMusteri();

            musteri3.ID = 6;
            musteri3.MusteriNo = "4141";
            //musteri3.((gercekMusteri).);


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri1);
            musteriManager.Ekle(tuzelMusteri1);
            musteriManager.Ekle(musteri3);
                
           
        }
    }
}
