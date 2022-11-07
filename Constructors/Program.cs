using System;

namespace Constructors
{
    //Bir class'ı newlediğimizde çalışan yapı
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1= new Customer() { ID = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
            //customer1.ID = 1;
            //customer1.FirstName = "Engin";Yukarıdaki kullanımın diğer kullanım versiyonu

            Customer customer2 = new Customer(2,"ayşe","demiroğ","eskişehir");
            //burada uyarı verdii.erik bilgileri tanıtılmadığı için metodmuşcasına parametreleri i.ine alan bir const daha tanımlayalım

            Console.WriteLine(customer2.FirstName);//ekrana basmaz aslında const a yukarıdaki parametre gider bunun için aşağıdaki const da değerleri set etmeliyiz

        }
    }
    class Customer
    {   public Customer()
           {
           //ilk newlenen burada çalışır parametre almayan customer1 defoult cont parametresi olmayan cont demek
           }
        public Customer(int id,string firstName, string lastName, string city)//metod parametreleri camelCase yazılır
           {
            Console.WriteLine("Yapıcı Blok Çalıştı");
            //değerlerin yukarıda conswriteln içinde ekrana basılabilmesi için burada set etmeliyiz
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            //customer2 burada çalışır parametre alan
           }
        //ctor yazıp tabla,class ın ismiyle aynı olur ve yukarıda classı newledimizde çalışır
        //biz const yazarsak cons içeriği çalışır, const oluşturmasakta yukarıda class newlendiğinde default olrk aslında bir cons çalışr
       
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
