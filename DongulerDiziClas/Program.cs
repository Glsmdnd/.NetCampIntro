using System;

namespace DongulerDiziClas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
     
                bool sistemeGirisYapmismi = true;

                //2) e-ticaret sistemine girişi yapılacak ürünler (clasların tip ve değer atamaları)
                
                Product product1 = new Product();
                product1.productID = "101";
                product1.productName = "Iphone 6s Plus";
                product1.productPrice = "4000";

                Product product2 = new Product();
                product2.productID = "102";
                product2.productName = "Iphone 7s Plus";
                product2.productPrice = "7000";

                Product product3 = new Product();
                product3.productID = "103";
                product3.productName = "Iphone 11 Plus";
                product3.productPrice = "14000";
                //3) e-ticaret sistemine giriş kontrolü
                if (sistemeGirisYapmismi == true)
                {
                    //4) Ürünleri diziye  yerleştirme
                    Product[] products = new Product[] { product1, product2, product3 };
                    //5) diziye yerleştirilen ürünleri ekrana foreach döngüsü ile yayınlama
                    Console.WriteLine("Foreach Döngüsü");
                    foreach (var product in products)
                    {
                        Console.WriteLine("ProductID:" + product.productID + " ProductName:" + product.productName + " ProductPrice:" +
                           product.productPrice);
                    }
                    //6) diziye yerleştirilen ürünleri ekrana for döngüsü ile yayınlama
                    Console.WriteLine("For Döngüsü");
                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine("ProductID:" + products[i].productID + " ProductName:" + products[i].productName + " ProductPrice:" +
                       products[i].productPrice);
                    }
                    Console.WriteLine("while Döngüsü");
                    int sayi = 0;
                    while (sayi < products.Length)
                    {
                        Console.WriteLine("ProductID:" + products[sayi].productID + " ProductName:" + products[sayi].productName + " ProductPrice:" +
products[sayi].productPrice);
                        sayi++;
                    }
                }
            }
            //1) e-ticaret sistemine girişi yapılacak ürünlerin tanımı
            class Product
            {
                public String productID { get; set; }
                public String productName { get; set; }
                public String productPrice { get; set; }
            }
        }
    }
 