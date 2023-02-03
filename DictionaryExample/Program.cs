using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                {101, "Scott" },
                {102, "Vijay" },
                {103, "Ajay" },
                {104, "Vinay" },
                {105, null }
            };

            //Remove
            employees.Remove(101);

            Console.WriteLine("ContainsKey(101): " + employees.ContainsKey(101));
            Console.WriteLine("ContainsValue(\"Vinay\"): " + employees.ContainsValue("Vinay") + "\n");

            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            // get value based on the key
            string s = employees[103];
            Console.WriteLine("\nValue at 101:" + s);

            // keys
            Dictionary<int, string>.KeyCollection keys = employees.Keys;

            foreach(int item in keys)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
