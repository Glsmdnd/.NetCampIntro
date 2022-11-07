using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kurs tipinde(STRİNG GİBİ) bir değişken tanımladım, değişkenimin birden fazla niteliği olduğu için
            //aslında Kurs tipinde bir nesne tanımladım telefon gibi düşün birden fazla özelliği olan bir nesne arama,telçekme,galeri öz gibi 
            //bir class değişkenini oluşturup değer atamakda böyle
            Kurs kurs1 = new Kurs();
            //şimdi bu nesnenin  özelliklerinin içeriklerini tanımlayalım
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 60;

            //birinci kurs bitti
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Programlama Temel Kurs";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.izlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.izlenmeOrani = 60;
            // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
            //içinde kurs nesnesini barındıran arrayi tanımlayalım
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        //şimdi bu nesnenin  özelliklerinin  tanımlayalım
        //bir class tanımlamak için yapılacak işlem bu
        public String KursAdi { get; set; }
        public String Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
