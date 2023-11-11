using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferencesTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            //num 1 ?? 30
            // int, decimal, flood, double, bool = value type

            int[] nums1 = new int[] {10, 20, 30};
            int[] nums2 = new int[] { 100, 200, 300 };
            nums1 = nums2;
            nums2[0] = 999;
            //nums2[0] 999
            // array, class, interface = reference type

            // STACK                    HEAP
        }
    }  
}  
