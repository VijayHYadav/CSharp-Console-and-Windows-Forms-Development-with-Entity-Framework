using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection
            List<int> list = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 40 };

            // Sort
            list.Sort();

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            // Reverse
            list.Reverse();
            
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
