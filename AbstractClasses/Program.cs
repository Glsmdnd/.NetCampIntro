using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Amevzuat amevzuat = new Amevzuat();
            amevzuat.kaydet();
            amevzuat.Degerlendir();
        }
        abstract class MevzuatBase
        {
            public abstract void Degerlendir();//abs de yarım operasyonda herkez bunu kendine göre implemente etsin
            public void kaydet() //ikisindede ortak olan bir metot yapalım
            {
                Console.WriteLine("kaydedildi ortak");
            }
        }
        class Amevzuat : MevzuatBase
        {
            public override void Degerlendir()
                //override etmesi  public abstract void Degerlendir(); metodunu kullanan sınıflarda metot içi aynı olmayabilir herkez kendi kodunu yazabilir
            {
                Console.WriteLine("A mevzuatına göre değerlendirildi");
            }
        }
        class Bmevzuat : MevzuatBase
        {
            public override void Degerlendir()
            {
                Console.WriteLine("B mevzuatına göre değerlendirildi");
            }
        }
    }
}
