using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
        //interfaceler şablon görevi görecek normalde hepsi için ayrı ayrı classlar açılmalı ,Kelime başına intfc oldu anlaşılsın diye I konur
        //interface ler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız(if gibimsi)
        //bu örnekte kredi türlerinin hepsinde hesaplama yani bir geri ödeme planı vardır.300 krediye sahipse banka hepsi için aynı
        //fakat vddk nın kuralları her kresi için faizdi kurallardı değişkenlik gösterir
    {
        public void Hesapla();
        public void BiseyYap();
        
    }
}
