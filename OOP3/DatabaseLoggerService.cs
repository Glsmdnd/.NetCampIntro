using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //sen aslında bir ILoggerService alternatisin
    //interface içinde sadece sadece imza metotlar olur içi dolu olamaz
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veri tabanına loglandı");
        }
    }
}
