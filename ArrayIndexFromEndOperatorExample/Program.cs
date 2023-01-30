using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexFromEndOperatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 3, 1, 2, 4 };

            // index-from-end operator
            int result = a[^1];
            Console.WriteLine(result); // Output: 60

            // range operator
            int[] result2 = a[2..5];
            Console.WriteLine(result2); // Output: [20,30,40]

            foreach (int i in result2) Console.WriteLine(i);
        }
    }
}
