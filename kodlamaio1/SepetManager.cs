using System;
using System.Collections.Generic;
using System.Text;

namespace kodlamaio1
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adi);

        }

        public void Ekle0(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi);
        }
    }
}
