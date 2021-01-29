using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Meyveler = new string[] { };
            Product urun1 = new Product();
            urun1.Adi = "ELMA";
            urun1.fiyati = 5;
            urun1.açiklama = "amasya elması";
            urun1.stogAdetı = 5;


            Product urun2 = new Product();
            urun2.Adi = "KARPUZ";
            urun2.fiyati = 100;
            urun2.açiklama = "DIYARBAKIR";
            urun2.stogAdetı = 90;

            Product[] urunler = new Product[] { urun1, urun2 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.açiklama);
                Console.WriteLine("--------------");

            }
            Console.WriteLine("-----------METHODS------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("ARMUT", "YEŞİL", 12);
            sepetManager.Ekle2("elma", "YEŞİL", 4);
            sepetManager.Ekle2("karpuz", "adana", 90);
            Console.WriteLine("-----------------------");
            
        }
    }
}
