using System.Collections.Generic;

namespace ListInsertExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>(10) { 1, 2, 6 };

            // index, new value
            myList.Insert(0, 0);

            myList.InsertRange(3,new List<int>(10) { 3, 4, 5 });

            for (int i = 0; i < myList.Count; i++)
            {
                System.Console.WriteLine(myList[i]);
            }

            System.Console.ReadKey();
        }
    }
}
