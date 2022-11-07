using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //t.must coorporate
    //miras inheritance müsterde olan özellikler artık gerçektede tüzeldede vardır.
    //TuzelMusteri inheritance/extend/veya miras alır Musteriden
    //Tuzel Musteri aslında bir musteri clasıdır./ebebeynı musteridir.
    class TuzelMusteri:Musteri
    {
        // public int ID { get; set; }gerçek ve tüzeldede old için bunları ortaga aldık(musteri classın içine)
        // public string MusteriNo { get; set;}gerçek ve tüzeldede old için bunları ortaga aldık(musteri classın içine)
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}
