using System;

namespace SortArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 3, 1, 2, 4 };

            Array.Sort(a);

            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
