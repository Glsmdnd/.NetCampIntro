using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
            new Worker(),
            new Manager(),
            new Robot()
           };//vrker için robot için ve manager için çalışma işlemi yaptım foreachle dolaşıp tüm personele çalışma emri verelim
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
                //buraya new dedimizde robot gelmiyor çünkü robot yemek yiyemez
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
        interface IWorker
        {
            void Work();
           
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }
        class Manager : IWorker, ISalary, IEat
        {
            public void Eat()
            {
                Console.WriteLine("Manager yemek yedi");
            }

            public void GetSalary()
            {
                Console.WriteLine("Manager maaş aldı");
            }

            public void Work()
            {
                Console.WriteLine("Manager çalıştı");
            }
        }
        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("worker yemek yedi");
            }

            public void GetSalary()
            {
                Console.WriteLine("worker maaş aldı");
            }

            public void Work()
            {
                Console.WriteLine("worker çalıştı");
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot çalıştı");
            }
        }
        //bir class birden fazla interface i implemente edebilir
    }
}
