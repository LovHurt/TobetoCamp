using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //one way to give fields
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //other way to give fields
            Product product2 = new Product
                { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase - camelCase         //To create reference types in heap, we must new it. (Referans tiplerin heap de oluşabilmesi için onu newlemeliyiz)
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);
            //Console.ReadLine();

            // In value types, assignments are entirely based on the value, and all connections are severed.
            // For example, when we declare int number = 100, if we pass the number to a function, we are actually 
            // sending only the value of the number, and any connection with the original number is completely cut

            // It came out as a 'Camera', because productName is a member of product1's class (so its a class ->reference type)
            // so due to its reference types, in heap it has an other address number and this
            // address number is changed with the old one.
            // And the int came out as 100 because its a value type

            productManager.Add2(3,6);
            int addResult = productManager.Add(3, 6);

        }
    }
}
