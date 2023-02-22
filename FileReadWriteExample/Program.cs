using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWriteExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"d:\practice\dog.txt";
            string content = "The dog is one of the common domestic animal.";

            //WriteAllText
            File.WriteAllText(filePath, content);
            Console.WriteLine("dog.txt created");

            //ReadAllText
            string s = File.ReadAllText(filePath);
            Console.WriteLine("\nFile read:");
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
