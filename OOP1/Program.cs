using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatogoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { UnitsInStock = 6, CatogoryId = 9, ProductName = "kalem", Id = 7, UnıtPrice = 9 };
            ProductManager productManager=new ProductManager();
            
            // int ,double ,bool ..değer tip
            // diziler,class,... referans tip

            Console.WriteLine(product1.ProductName);
            productManager.Add(product2);
           
           




        }
    }
}
