using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//101
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock=3;
            
            Product product2 = new Product();
            product1.ID = 2;
            product1.CategoryID = 2;
            product1.ProductName = "kalem";
            product1.UnitPrice = 80;
            product1.UnitInStock = 10;

            //Aslında bir değişkenin türünü tanıtır gibi intance örneğini oluşturuyoruz
            //case sensitive k-b harf duyarlı
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);//kamera
            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);//100
            //int,double,string...değer tip sayi1 gitti orda olan burayı etkilemedi
            //diziler,class,abstract class ..ref tip olduğundan diğer sayfadaki metodla değişti

            int toplamaSonucu=productManager.Topla(6, 3);
            Console.WriteLine(toplamaSonucu*2);

            //public int olan metodda işlem yaptırdık sonucu buraya çağırdık
            //ve hatta burada işlem yapmaya devam ettik
            productManager.Topla2(3, 6);
            //void li metod ise çalıştığı yerde kaldı bir değer döndermedi


        
        }
    }
}
