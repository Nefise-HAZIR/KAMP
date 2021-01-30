using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.IzlenmeOranı = 80;
            kurs1.Eğitmen = "ENGİN DEMİROĞ";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "JAVA";
            kurs2.IzlenmeOranı = 70;
            kurs2.Eğitmen = "AHMET";

            //Console.WriteLine(kurs1.KursAdı+" "+kurs1.IzlenmeOranı+" "+kurs1.Eğitmen);
            //Console.WriteLine(kurs2.KursAdı + " " + kurs2.IzlenmeOranı + " " + kurs2.Eğitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı+" "+kurs.Eğitmen+" "+kurs.IzlenmeOranı);
                
            }
        }
        class Kurs
        {
            public string KursAdı { get; set; }
            public string Eğitmen { get; set; }
            public int IzlenmeOranı { get; set; }
        }
    }
}
