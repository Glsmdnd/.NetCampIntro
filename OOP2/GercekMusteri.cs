using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri : Musteri
    {
        //invidual bireysel musteri

        //  public int ID { get; set; }gerçek ve tüzeldede old için bunları ortaga aldık(musteri classın içine)
        public string TcNo { get; set; }
        // public string MusteriNo { get; set; }gerçek ve tüzeldede old için bunları ortaga aldık(musteri classın içine)
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
