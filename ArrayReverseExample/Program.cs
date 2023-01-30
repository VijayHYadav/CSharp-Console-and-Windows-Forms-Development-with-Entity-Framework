using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 3, 1, 2, 4 };

            // Array.Sort
            Array.Sort(a);

            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }

            // Array.Reverse
            Array.Reverse(a);

            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
