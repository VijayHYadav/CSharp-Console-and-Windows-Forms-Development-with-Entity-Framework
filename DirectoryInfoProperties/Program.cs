using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirPath = @"c:\practice\world";
            DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
            Console.WriteLine("Exists: " + directoryInfo.Exists);
            if (directoryInfo.Exists)
            {
                Console.WriteLine("Full Name: " + directoryInfo.FullName);
                Console.WriteLine("Name: " + directoryInfo.Name);
                Console.WriteLine("Directory Name: " + directoryInfo.Parent);
                Console.WriteLine("Root: " + directoryInfo.Root);
                Console.WriteLine("Creation date and time: " + directoryInfo.CreationTime);
                Console.WriteLine("Last modification date and time: " + directoryInfo.LastWriteTime);
                Console.WriteLine("Lat access date and time: " + directoryInfo.LastAccessTime);
            }
            Console.ReadKey();

        }
    }
}
