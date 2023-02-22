using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLinesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection
            List<string> asia = new List<string>() { "Russia", "China", "India" };

            //file path
            string filePath = @"d:\practice\asia.txt";

            //WriteAllLines
            File.WriteAllLines(filePath, asia);
            Console.WriteLine("asia.txt created");

            //ReadAllLines
            string[] existingContent = File.ReadAllLines(filePath);
            foreach (string line in existingContent)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
