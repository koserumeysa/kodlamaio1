using System;

namespace RefOutParametreleri
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sayi = 5;
            int sayi2 = 7;
            Console.WriteLine("**********");
            Console.WriteLine("Metot Öncesi:\nBirinci sayi = {0}\nİkinci sayı = {1}", sayi, sayi2);
            var toplam = Toplam_ref(ref sayi, sayi2);
            Console.WriteLine("**********");
            Console.WriteLine("Metot Sonrası:\nBirinci sayi = {0}\nİkinci sayı = {1}", sayi, sayi2);
            Console.WriteLine("Sayıların toplamı = " + toplam);

            int sayi3 = 4;
            int sayi4 = 7;
            Console.WriteLine("**********");
            Console.WriteLine("Metot Öncesi:\nBirinci sayi = {0}\nİkinci sayı = {1}", sayi3, sayi4);
            toplam = Toplam_out(out sayi3, sayi4);
            Console.WriteLine("**********");
            Console.WriteLine("Metot Sonrası:\nBirinci sayi = {0}\nİkinci sayı = {1}", sayi3, sayi4);
            Console.WriteLine("Sayıların toplamı = " + toplam);
        }

        static int Toplam_ref(ref int sayi, int sayi2)
        {
            sayi = 10;
            return sayi + sayi2;
        }
        static int Toplam_out(out int sayi, int sayi2)
        {
            sayi = 10;
            return sayi + sayi2;
        }
    }
}
