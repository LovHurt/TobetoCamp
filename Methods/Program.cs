using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Diyarbakır Watermelon";

            Product[] products = new Product[] { product1, product2 };

            // type-safe -- tip güvenli
            foreach (var product in products)
            {

                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.UnitsInStock);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("----------Methods------------");

            //Instance
            //Encapsulation
            CartManager cartmanager = new CartManager();
            cartmanager.Add(product1);
            cartmanager.Add(product2);


            cartmanager.Add2("Banana", "Green Banana", 12, 10);
            cartmanager.Add2("Watermelon", "Yellow Watermelon", 22, 8);
            cartmanager.Add2("Apple", "Red Apple", 32, 6);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

       
    }
}

//Dont Repeat Yourself - DRY - Clean Code - Best Practice