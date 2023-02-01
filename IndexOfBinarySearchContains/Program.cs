using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfBinarySearchContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection
            List<int> list = new List<int>() { 10,20,30,40,50,60,70,80,90,100,40 };

            //search for 40
            int sixty = list.IndexOf(40);

            Console.WriteLine(sixty);

            // searching for second occurence 40
            sixty = list.IndexOf(40, 4);

            Console.WriteLine(sixty);

            int zero = list.IndexOf(0);

            Console.WriteLine(zero);

            int searchFor70 = list.BinarySearch(100);
            Console.WriteLine("searchFor70: " + searchFor70);

            bool is100Contains = list.Contains(100);
            Console.WriteLine(is100Contains);

            bool is200Contains = list.Contains(200);
            Console.WriteLine(is200Contains);
        }
    }
}
