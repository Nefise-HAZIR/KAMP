using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Nefise";
            musteri1.Soyadi = "Hazır";
            musteri1.TcNo = "123456";
            musteri1.Id = 6;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "987654";
            musteri2.SirketAdi = "GUZEL";
            musteri2.VergiNo = "1234567";


            Musteri musteri3 = new GercekMusteri(); // new =referans no diyebiliriz.
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
        }   
    }
}
