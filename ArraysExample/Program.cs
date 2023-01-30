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

            for(int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            foreach(string i in c)
            {
                Console.WriteLine(i);
            }

            System.Console.WriteLine();

            //reverse
            for(int i = c.Length -1 ; i >=0 ; i--)
            {
                Console.WriteLine(c[i]);
            }

            System.Console.ReadKey();
        }
    }
}
