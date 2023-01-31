using System;
using System.Collections.Generic;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create reference variable for List class
            List<int> myList;

            //create object of List class. 10 is the capacity for the list
            myList = new List<int>(10) { 1, 2, 3 };

            foreach (int item in myList)
            {
                System.Console.WriteLine(item);
            }

            for (int i = 0; i < myList.Count; i++)
            {
                System.Console.WriteLine(myList[i]);
            }

            System.Console.ReadKey();
        }
    }
}
