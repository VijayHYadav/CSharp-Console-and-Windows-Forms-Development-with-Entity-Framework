using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingStringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Developer";
            Console.WriteLine(str); // Output:
            
            Console.WriteLine(str.ToUpper()); // Output:
            Console.WriteLine(str.ToLower()); // Output:
            Console.WriteLine(str);

            Console.WriteLine(str.Substring(2));
            Console.WriteLine(str.Substring(2, 4));

            Console.ReadKey();
        }
    }
}
