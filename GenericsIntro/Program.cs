using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLıst<string> isimler = new MyLıst<string>();
            isimler.Add("Nefise");
            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);


        }
          
    }
}
