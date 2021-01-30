using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "YAZILIM GELİŞTİRİCİ KAMPI", "PROGRAMLAMAYA BAŞLANGIÇ", "JAVA", "PYTHON","C++" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine( "FOR BİTTİ");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }



            Console.WriteLine("SAYFA SONU-FOOTER");

            
        }
    }
}
