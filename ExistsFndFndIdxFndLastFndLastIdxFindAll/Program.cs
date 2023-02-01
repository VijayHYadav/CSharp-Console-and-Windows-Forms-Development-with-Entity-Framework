using System;
using System.Collections.Generic;

namespace ExistsFndFndIdxFndLastFndLastIdxFndAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 40 };

            // Exists
            bool b = list.Exists((n) => n == 10);
            if (b == true)
            {
                Console.WriteLine("B if :" + b);
            } else if (b == false)
            {
                Console.WriteLine("B else if :" + b);
            }

            // Find: Get marks of first failed subject
            int firstMatchingElement = list.Find(item => item < 50);

            Console.WriteLine("firstMatchingElement"+ firstMatchingElement);

            // FindIndex
            int firstIndexOf = list.FindIndex(item => item < 50);

            Console.WriteLine("firstIndexOf" + firstIndexOf);

            int lastMatchingElement = list.FindLast(item => item < 50);

            Console.WriteLine("lastMatchingElement" + lastMatchingElement);

            int lastIndexOf = list.FindLastIndex(item => item < 50);

            Console.WriteLine("lastIndexOf" + lastIndexOf);

            List<int> listOfAllStatifyingEle = list.FindAll(item => item < 50);

            foreach (var item in listOfAllStatifyingEle)
            {
                Console.WriteLine("listOfAllStatifyingEle" + item);
            }


            Console.ReadKey();
        }
    }
}
