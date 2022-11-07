using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention isimlendirme kuralı Ekle buyuk basharfi
        //syntax yazım şekli
        public void Ekle(Urun urun)
            {
            Console.WriteLine("Tebrikler, Sepete "+urun.Adi+" Eklendi");
            }
        public void Ekle2(String urunAdi, String urunAciklamasi, Double UrunFiyati,int stokAdedi) 
        {
            Console.WriteLine("Tebrikler, Sepete " + urunAdi+" eklendi.");
        }
    }
}
