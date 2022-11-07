using System;

namespace Inheritance
{
    class Program
    {   //inheritance kalıtım -miras interfacelerde inheritance gibi miras gibimsi çalışsada aslında onlar implementasyon yaparlar
        //interfacelerin tek başlarına bir anlamı yoktur,classların vardır
        //bir class sadece bir clasın inheritance ı mümkündür,fakat bir class birden fazla interface i implemente edebilirler
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person{FirstName="Gülsüm" },
                new Customer{FirstName="Aselcim" },
                new Student{FirstName="Miçin" },
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName); 
            }
        }
        interface IPerson
        {

        }
        interface IPerson2
        {

        }
        class Person
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer:Person,IPerson,IPerson2
            //customerin babası persondur birden fazla class miras alamaz ama birden fazla interface implementasyonu olabilir
        {
            public string city { get; set; }
        }
        class Student:Person
        {
            public string Department { get; set; }
        }
    }
}
