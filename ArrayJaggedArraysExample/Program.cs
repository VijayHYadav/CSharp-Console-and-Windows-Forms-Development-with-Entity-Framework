using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayJaggedArraysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[3] { 10, 20, 30 };
            a[1] = new int[3] { 40, 50, 60 };
            a[2] = new int[3] { 70, 80, 90 };

            // read
            for(int i=0; i<3; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine(a[i][j]);
                    Console.WriteLine("");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
