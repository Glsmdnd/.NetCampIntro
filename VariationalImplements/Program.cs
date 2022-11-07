using System;

namespace VariationalImplements
{
    class Program
    {
        static void Main(string[] args)
        {
            //türüne göre (mevzuat 1 veya mevzuat 2 ye göre)müşteri ekleme varyasyonunu kodlayalım
            CustomerManagement customerManagement = new CustomerManagement(new BirinciMevzuat());
            customerManagement.Add();
        }

        class CustomerManagement
        {//constructor blogunda Imevzuatı ekliyoruz
            //customerManager newlendiğinde Imevzuat turunde bir değişken istesin tek başına interfaceler newlenemiyor
            private IMevzuat _mevzuat;
            public CustomerManagement(IMevzuat mevzuat)
            {
                _mevzuat = mevzuat;
            }
            public void Add()
            {
                _mevzuat.IslemYap();
            }
        }
        interface IMevzuat //bir implementasyon olrk verildiğinde tüm classların referanslarını tutbiliyor
        {
            void IslemYap();
        }
        class BirinciMevzuat : IMevzuat//bu bir IMevzuat implementasyonudur.Yani işlemyapı doldurduğumuz yerdir
        {
            public void IslemYap()
            {
                Console.WriteLine("Birinci Mevzuata Göre Müşteri Kaydedildi");
            }
        }
        class IkinciMevzuat : IMevzuat//bunun gibii yeni bir mevzuat geldiğinde mevzut yapım hiç bbozulmamış olur
        {
            public void IslemYap()
            {
                Console.WriteLine("İkinci Mevzuata Göre Müşteri Kaydedildi");
            }
        }
    }
}
