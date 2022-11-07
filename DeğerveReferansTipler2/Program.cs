using System;

namespace DeğerveReferansTipler2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////değer tip
            //int sayi1 = 20;
            //int sayi2 = 40;
            //sayi1 = sayi2;
            //sayi2 = 100;
            ////sayilar1 in içi ssayi2 değerini aldı yani 40 sonra değişmesi sayi1 i bağlamaz
            //Console.WriteLine("sayi1 in değeri" + sayi1);

            ////referans tip
            //int[] sayilar1 = new int[] { 10, 20, 30 };
            //int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            ////sayilar1[0] indisi sayilar2[0] refere edeceğinden 1000 olarak ekrana yazar 
            //Console.WriteLine("sayilar1 dizisinin [0] indisi" + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person1 = person2;
            person2.FirstName = "Şule";
            Console.WriteLine("person1 person2 yi refere edeceğinden person1 ekrana "+person1.FirstName+" yazar.");

            Customer customer = new Customer();
            customer.CreditCardNumber = "25463";
            customer.FirstName = "Gülsüm";//first name person clasına ait bir özellik olmasına rağmen customer clasından ona ulaşabildik inheritance özelliği
            Person person3= customer;//person classınnın 3.personuna customer mizi atadık .customerin firsname Gülsümdü.atama sayesinde person3 ünde first name gülsüm oldu
            Console.WriteLine(person3.FirstName);
            //base sınıfa miras aldımız sınıfı atayabiliriz Person person3= customer; gibi
            //miraslardan çocuklardan ebebeyn yani base sınıf özelliklerine ulaşabilirken  customer.firstname gibi
            //base sınıftan nedne mirasların özelliklerine ulaşamıyoruz yöntemi
            Console.WriteLine(((Customer)person3).CreditCardNumber);//person3 e customer boxingi yap,böylelikle base den diğer clas özelliklerne ulaşalım

            //person base clası employee hemde customer ın adresini tutabiliyor 
            //aşağıda personManager isimli bir class daha oluştutup içine personu koyalım add metodunda hem customera hem employee ulaştımızı göreceksiniz
            personManager manager = new personManager();
            manager.Add(customer);

        }
    }
     class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
    }

    class Employee: Person//person base sınıfından özellikleri alması için inheritance ettik
    {
        public int EmployeeNumber { get; set; }
    }

    class Customer:Person//person base sınıfından özellikleri alması için inheritance ettik
    {
        public string CreditCardNumber { get; set; }
    }
    class personManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
          //  personManager isimli bir class daha oluştutup içine personu koyalım add metodunda hem customera hem employee ulaştımızı
    }
    }
}
