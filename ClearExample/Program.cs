using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * array: this parameter represents the array, in which you want to clear the elements
 * index: this parameter represents the index, from which clearing process is to be started.
 * length: this parameter represents the no. of elements that are to be cleared.
 * **/

namespace ClearExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create array
            int[] a = new int[] { 1, 2,3, 4 };

            //clear elements of array, Array.Clear(array, startingIndex, endingIndex);
            Array.Clear(a, 0, a.Length);

            // display array
            foreach (int item in a)
            {
                System.Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
