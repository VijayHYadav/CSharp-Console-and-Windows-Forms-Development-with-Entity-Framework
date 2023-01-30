using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create array
            double[] a = new double[6] { 10,20,30,40,50,30 };

            // search for 30 in the array
            int n = Array.IndexOf(a, 30);

            // search for 30 in the array
            int next30 = Array.IndexOf(a, 30, 3);

            // search for 100 in the array (not exists)
            int n3 = Array.IndexOf(a, 100);

            System.Console.WriteLine("30 is found at "+n);
            System.Console.WriteLine("next30 is found at " + next30);
            System.Console.WriteLine("n3 is found at " + n3);

            System.Console.ReadKey();

            /**
             * Array.IndexOf(array, value, startIndex);
             * array: This parameter represents the array, in which you want to search.
             * value: This parameter represents the actual value that is to be searched.
             * startIndex: This parameter represents the start index, from where the search sould be started.
             */
        }
    }
}
