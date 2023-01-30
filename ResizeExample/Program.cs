using System;

namespace ResizeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2,3, 4 };

            // resize array to 5
            Array.Resize(ref a, 2);

            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
