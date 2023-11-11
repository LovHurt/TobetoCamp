using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        //Encapsulation
        public void Add(Product product)//101
        {
            //product.ProductName = "Camera";
            Console.WriteLine(product.ProductName + " has been added");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " has been updated");
        }

        public void Delete(Product product)
        {

        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public void Add2(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }


        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}
    }
}
