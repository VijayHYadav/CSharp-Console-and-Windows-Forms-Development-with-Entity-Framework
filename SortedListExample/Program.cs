using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a sortedlist
            SortedList<int, string> employees = new SortedList<int, string>() {
                {101, "Scott" },
                {102, "smith" },
                {103, "Allen" },
                {104, "Jones" },
                {105, "James" }
            };

            // Add element
            employees.Add(107, "Bella");
            employees.Add(106, "Anna");

            // Remove element
            employees.Remove(103);

            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine("item.Key: " + item.Key +"==="+ "item.Value: " + item.Value + "\n");
            }

            // get value based on key
            string eName = employees[105];

            Console.WriteLine(eName + "\n");

            Console.WriteLine("employees.ContainsKey(105) : " + employees.ContainsKey(105));
            Console.WriteLine("employees.ContainsValue(105) : " + employees.ContainsValue("smith"));

            Console.WriteLine();

            Console.WriteLine("employees.ContainsKey(105) : " + employees.ContainsKey(105));
            Console.WriteLine("employees.ContainsValue(105) : " + employees.ContainsValue("smith"));

            Console.WriteLine();

            Console.WriteLine("employees.IndexOfKey(105)" + employees.IndexOfKey(105));
            Console.WriteLine("employees.IndexOfValue(\"smith\")" + employees.IndexOfValue("smith"));

            Console.WriteLine();

            foreach (int item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            
            foreach (string item in employees.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
