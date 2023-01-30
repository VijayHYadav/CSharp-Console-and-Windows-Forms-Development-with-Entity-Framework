using System;

namespace BinarySearchExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[6] { 10, 20, 30, 40, 50, 60 };

            //search for 30 in the array(first half)
            int n = Array.BinarySearch(a, 30);
            Console.WriteLine("30 is found at:" + n);

            //search for 60 in the array(first half)
            int n2 = Array.BinarySearch(a, 60);
            Console.WriteLine("60 is found at:" + n2);

            int n3 = Array.BinarySearch(a, 100);
            Console.WriteLine("100 is found at:" + n3);

        }
    }
}
