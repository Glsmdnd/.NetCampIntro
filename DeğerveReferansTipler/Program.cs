using System;

namespace DeğerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1=sayi2;
            sayi2 = 400;
            Console.WriteLine("sayi1"+sayi1);  
            //sayi1 ? 30 olur
            //int,decimal,string,float,double,bool=değer tip
            //buradaki  değişken atamalarında stack ve heap isimli iki alandan stacki kullanır,sayi ikinin değeri sayi 1 e atandığında
            //sayi1 in önceki değeri stackten silinir,yeni değer gelir.sayi 2 nin sonradan değiştirilmesi sayi biri bağlamaz

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine("sayilar1[] 0. indisini ver:"+sayilar1[0]);
            //sayilar1[0] ? 999 olur
            //array,class,interface =referans tiplerdir
            //buradaki  değişken atamalarında stack ve heap isimli iki alandan hem stacki hem heapi kullanır sayilar1 ve sayilar2 dizisinde new kelimesi
            //ile heapte stackdeki bu değişken için bir adres olşturulur.sayilar1=sayilar2 eşitliğinde sayilar1 ,sayilar2 nin adresi heap teki değerine bağlanır.
            //örn sayilar1 dizisinin heapdeki referans adresi 101, sayilar2 nin heapi 102 olsun sayilar1=sayilar2 eşitlemesinde artık sayilar1 in referans adresi
            //102 olmuş oluur.Bu sebeple sayi2[0] indisine yeni bir değer atansa bile sayi1 onun adresini referans ettiğinden yeni atanan değer geçerli olur
            //101 numaralı heap ise boşa çıktığından (artık bir değişkene refere etmediğinden) visual stdo garbage collector tarafından silinir
            
        }
        
      }
}
