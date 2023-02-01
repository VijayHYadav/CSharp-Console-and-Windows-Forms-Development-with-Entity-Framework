using System;
using System.Collections.Generic;

namespace ToArrayForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection
            List<int> list = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 40 };

            // conver to array
            int[] listToArray = list.ToArray();

            foreach (var item in listToArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
