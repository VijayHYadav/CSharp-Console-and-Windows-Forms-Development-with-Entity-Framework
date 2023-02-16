using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello World";
            string y = "Hello World";
            string z = x;
            x = "hello";

            Console.WriteLine(x); //hello
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
