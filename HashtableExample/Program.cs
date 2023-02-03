using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable employees = new Hashtable() {
                {101, "Scott" },
                {102, "smith" },
                {103, "Allen" },
                {104, "Jones" },
                {105, "James" },
                {"smit", 106 }
            };

            // Add element
            employees.Add(107, "Bella");

            // Remove element
            employees.Remove(103);

            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine("item " + item.Key +":"+item.Value + "\n");
            }

            // get value based on key
            if (employees[105] is string)
            {
                string value = Convert.ToString(employees[105]);
                Console.WriteLine(value+ "\n");
            }

            if (employees[105] is double)
            {
                double value = Convert.ToDouble(employees[105]);
                Console.WriteLine(value + "\n");
            }

            if (employees[105] is int)
            {
                int value = Convert.ToInt32(employees[105]);
                Console.WriteLine(value + "\n");
            }

            Console.WriteLine("employees.ContainsKey(105) : " + employees.ContainsKey(105));
            Console.WriteLine("employees.ContainsValue(105) : " + employees.ContainsValue("smith"));

            Console.WriteLine();

            Console.WriteLine("employees.ContainsKey(105) : " + employees.ContainsKey(105));
            Console.WriteLine("employees.ContainsValue(105) : " + employees.ContainsValue("smith"));

            Console.WriteLine();

            foreach (var item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
