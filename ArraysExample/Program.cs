using System;

namespace ArraysExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array, Arrays are stored in the heap and the reference variables are stored in the stack.
            int[] a = new int[5];
            int[] b = new int[5] { 1,2,3,4,5};
            string[] c = new string[5] { "one","two","three","four","five"};

            System.Console.WriteLine(a[0]);

            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;

            System.Console.WriteLine(a[0]);
            System.Console.WriteLine();
            System.Console.WriteLine(c[0]);
            System.Console.WriteLine(c[1]);
            System.Console.WriteLine(c[2]);
            System.Console.WriteLine(c[3]);
            System.Console.WriteLine(c[4]);

            System.Console.ReadKey();
        }
    }
}
