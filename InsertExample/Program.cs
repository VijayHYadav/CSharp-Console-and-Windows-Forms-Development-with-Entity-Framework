using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Developer";
            Console.WriteLine(name.Insert(3, "hello"));
            Console.WriteLine(name.Remove(2, 2));

        }
    }
}
