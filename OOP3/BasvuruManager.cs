using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {   
        //methot injection yapıyoruz yani basvuruYap metodunun kredi türü olcanı ve hangi loglayıcı olacağını enjekte ediyoruz
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();//hangi loger servis gönderilmişse onu logla
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
            //listedeki her bir kredinin hesabını yap
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
