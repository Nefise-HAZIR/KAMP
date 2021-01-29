using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle( Product urun)
        {
            Console.WriteLine("SEPETE EKLE:  "+urun.Adi);
            Console.WriteLine("SEPETE EKLE:  " + urun.açiklama);
            Console.WriteLine("SEPETE EKLE:  " + urun.fiyati);
            Console.WriteLine("SEPETE EKLE:  " + urun.stogAdetı);
        }
        public void Ekle2(string urunAdı,  string urunAçıklama, double fıyatı  )
        {
            Console.WriteLine("TEPRİKLER SEPETE EKLENDİ:"+urunAdı);
            Console.WriteLine("TEPRİKLER SEPETE EKLENDİ:"+urunAçıklama);
            Console.WriteLine("TEPRİKLER SEPETE EKLENDİ:" + fıyatı);


        }

        
    }
}
