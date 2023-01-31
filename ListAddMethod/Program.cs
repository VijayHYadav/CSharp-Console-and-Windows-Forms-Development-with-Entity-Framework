using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAddMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>(10) { 1, 2, 3 };

            myList.Add(4);
            myList.Add(5);

            List<int> myList2 = new List<int>(10) { 10, 20, 30 };

            myList.AddRange(myList2);

            for (int i = 0; i < myList.Count; i++)
            {
                System.Console.WriteLine(myList[i]);
            }

            System.Console.ReadKey();

        }
    }
}
