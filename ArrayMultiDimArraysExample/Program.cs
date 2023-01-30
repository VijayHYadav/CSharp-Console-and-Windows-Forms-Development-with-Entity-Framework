using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiDimArraysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // multi-dim array 4X3
            int[,] a = new int[4, 3] {
                {10,20,30 },
                {40,60,70 },
                {80,90,100 },
                {110,20,30 },
            };

            // read data from multi-dim array
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(a[i, j]);
                    Console.Write("");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
