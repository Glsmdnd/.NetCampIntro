using System;

namespace Metotlar
{
    class Program
    {
        //metodlar takrar tekrar kullanılabilirliği sağlıyor
        //do not repeat your self- DRY- Clean Cod- Best Practise(Doğru Uygulama Teknikleri)
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Aciklama = "amasya";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "ayva";
            urun2.Aciklama = "Eşme-Sünger";
            urun2.Fiyati = 25;

            Urun[] urunler = new Urun[] { urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("ürün Adı:" + urun.Adi);
                Console.WriteLine("ürün Aciklama:" + urun.Aciklama);
                Console.WriteLine("ürün Fiyatı" + urun.Fiyati);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("METOTLAR");
            //instance class örneği oluşturcaz
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //iki alanda mantıken aynı şeyi yapar yukarıda özellikler klasta tutulurken alttaki örnekte parametre olarak girilmiştir.
            //buda yarın bir değişiklik oldu diyelim örneğin stok adadi eklensin dendiğinde alttaki alan sıkıntı yaratırken her sayfayı tektek düzenlemek gerekecekken
            //üstteki alanda classın tanımlı olduğu urun.cs'de sadece bir özellik eklemek yeterli olur, yapı bozulmaz,hersayfayı düzenlemeye gerek kalmaz
            sepetManager.Ekle2("elma", "yesil", 12,5);
            sepetManager.Ekle2("karpuz", "diyarbakır", 12,7);
        }
    }
}
