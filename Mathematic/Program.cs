using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematic
{
    public class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();
            fourOperations.Add(5,6);

            fourOperations.Add(6,9);

            Console.ReadLine();

        }
    }
}
