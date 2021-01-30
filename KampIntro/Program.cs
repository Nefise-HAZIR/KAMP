using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KonuEtiketi = "kategori";
            Console.WriteLine(KonuEtiketi);
            int OgrenciSayısı = 80;
            Console.WriteLine(OgrenciSayısı);
            double faizOranı = 1.45;
            Console.WriteLine(faizOranı);
            bool sistemeGrisYapmısMı = true;
            if (sistemeGrisYapmısMı==true)
            {
                Console.WriteLine(" GÖSTER:kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("GRİŞ YAP BUTONU");
            }
            double dolarDun=1.45;
            double dolarBugun=1.35;
            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("AZALIŞ BUTONU");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("ARTIŞ BUTONU");

            }
            else
            {
                Console.WriteLine("SABİT BUTONU");
            }
        }
            
            
    }
}
