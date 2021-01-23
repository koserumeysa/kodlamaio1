using System;

namespace kodlamaio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun0 = new Urun();
            urun0.Adi = "Elma";
            urun0.Fiyat = 15;
            urun0.Aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Karpuz";
            urun1.Fiyat = 80;
            urun1.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun0, urun1 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("------------Metotlar------------");
            //instance -örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun0);
            sepetManager.Ekle(urun1);

            sepetManager.Ekle0("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle0("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle0("Karpuz", "Diyarbakır Karpuzu", 12, 5);

        }
    }
}
