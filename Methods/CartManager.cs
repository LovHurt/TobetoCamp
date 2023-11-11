using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class CartManager
    {
        //Naming Convention
        public void Add(Product product)
        {
            Console.WriteLine("It has been added to Cart : "+ product.Name);
        }

        public void Add2(string productName, string Description, double Price, int UnitsInStock)
        {
            Console.WriteLine("Congratz. It has been added to cart :" + productName);
        }
    }
}
