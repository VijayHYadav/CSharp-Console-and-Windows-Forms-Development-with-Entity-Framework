using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashsetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of HashSet
            HashSet<string> messages = new HashSet<string>()
            {
                "Good Morning", "How Are You", "Have a good day"
            };

            messages.Add("Good Luck");

            messages.Remove("Good Morning");

            messages.RemoveWhere(m => m.EndsWith("day"));

            Console.WriteLine(messages.Count());

            Console.WriteLine(messages.Contains("How Are You"));

            foreach (string s in messages)
            {
                Console.WriteLine(s);
            }

            messages.Clear();

            Console.WriteLine(messages.Count());
        }
    }
}
