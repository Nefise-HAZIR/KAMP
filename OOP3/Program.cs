using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();

            //TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
                
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();//Interface referans no yu tutabiliyor ! 
            
            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new DatabaseLoggerService());
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
