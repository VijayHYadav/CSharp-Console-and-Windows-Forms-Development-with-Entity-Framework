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
            System.String x = "hello world";
            int n = x.Length;
            char c = x[0];
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
