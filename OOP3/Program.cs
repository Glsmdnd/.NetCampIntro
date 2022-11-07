using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler o interfacei implamente eden sınıfın referansını tutabilirler
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
           
            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);
            //adam belki ihtiyacı için birden fazla kredinin hesaplanmasını talep edebilir örn araba alcak hem arac kredisi hem iht kred hesaplanmasını talep edebilir.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //listedeki herbir kredinin hesabını yap
        }
    }
}
