// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace OOP1
{
     class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 3;
            product1.CategoryId = 4;
            product1.UnitsInStock = 5;
            product1.ProductName = "Masa";
            product1.UnitPrice = 25;

            Product produck2 = new Product { Id = 2, CategoryId = 3, UnitsInStock = 7, ProductName = "Kalem", UnitPrice = 85 };

            //PsacalCase   //CamelCase
            //Case sensitive

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

           



        }


    }
}



     