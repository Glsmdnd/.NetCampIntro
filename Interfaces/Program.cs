using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[2]
          {//elimizdeki veriyi şifketteki tüm vt lere atmak istiyoruz
              //bunun güzelliği yarın birgünyeni bir vt ile çalışmay abaşladığımızı varsayalım ör aşağıya oracle ,sql gibi my sql vt yi ekledik
              //bunun için sadece burada newlememiz gerekir başka birşeye gerek durmamış oluruz
            new SqlServerCustomerDal(),
            new OracleServerCustomerDal()
          };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();

        Customer customer1 = new Customer();
        customer1.ID = 1;
            customer1.FirstName = "Gülsüm";
            customer1.LastName = "Döndü";
            customer1.Departmant = "IT";
            personManager.Add(customer1);

            Student student1 = new Student();
        student1.ID = 1;
            student1.FirstName = "Asel";
            student1.LastName = "Keskin";
            student1.Address = "serdar Mah";
            personManager.Add(student1);

        }
        interface IPerson
            //Buradaki ubyuk I interface in kısaltması
            //temel bir arayuz 
            //sınıfların soyut hali
            //interfacesler newlenemez classlar yoksa tek başına bir anlam ifade etmez
            //katmanlar arası geçişlerde kullanılır
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Student:IPerson//interfacei implement ettik
        {
            public int ID { get; set; } 
            public string FirstName { get; set; }
            public string LastName { get; set; }


            public string Address { get; set; }
        }
        class Customer:IPerson//customer sınıfı  person soyut clasını yani interfaceini implemente etti
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }

        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine("selam"+person.FirstName);
            }
        }
    }
}
