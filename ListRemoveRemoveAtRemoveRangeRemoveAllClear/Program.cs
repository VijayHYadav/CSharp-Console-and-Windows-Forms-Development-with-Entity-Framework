using System.Collections.Generic;

namespace ListRemoveRemoveAtRemoveRangeRemoveAllClear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60 };
            
            myList.Remove(60);
            myList.RemoveAt(3);
            myList.RemoveRange(2,2);
            myList.RemoveAll(n => n == 10);
            myList.Clear();

            foreach (var item in myList)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
