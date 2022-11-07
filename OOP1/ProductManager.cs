using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager 
     //CRUD
     //Create read uptadate delete gibi ürün operasyonları ...Manager sayfasında olur
    {
        public void Add(Product product)//101
        {
            product.ProductName = "kamera";
            //diğer sayfadaki Console.WriteLine(product1.productName) ekrana kamera basacaktır
            //int,double,string...değer tip 
            //diziler,class,abstract class ..ref tip olduğundan buradaki metod içi referans değişiminden diğer sayfa etkilendi
        }

        public void BiseyYap(int sayi)
        {
            sayi = 99;
            //diğer sayfadaki Console.WriteLine(sayi) ekrana 100 basacaktır
            //int,double,string...değer tip sayi1 gitti orda olan burayı etkilemedi
            //diziler,class,abstract class ..ref tip olduğundan diğer sayfadaki metodla değişti
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
