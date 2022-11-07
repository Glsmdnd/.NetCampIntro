using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
        //classların 2 temel görevi var 1)içinde özellikler tutmak   2)operasyonlar tutmak op tutulan yerde öz tutulmaz özel tutulan yerde operas tutulmaz
    {
        public int ID { get; set; }
        public string MusteriNo { get; set; }
        //vergiNo,mustNo gibi alanlar:sayı gibi top çık işlemler yaptırmıyorsak string kalmalılar
        //eğer bir nesnede bir değer kullanmak zorunda gibi görünmüyor,bu nesneye ait değilmiş gibi görünmüyorsa orda soyutlama hatası vardır
    }
}
