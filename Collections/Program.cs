using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //stack          heap(here it gets its address number like 101
            //string[] names = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            ////When we say 'new' a new address is created in heap so this new string[5] gonna
            ////create a new address in heap and it will be empty
            //names = new string[5];
            //names[4] = "ilker";


            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);

            //Console.ReadLine();

            //We usually use List instead of array

            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

            Console.ReadLine();

        }
    }
}
