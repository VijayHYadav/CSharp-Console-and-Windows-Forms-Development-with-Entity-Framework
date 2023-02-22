using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfoPropertiesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"d:\practice\japan.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine("Exists: " + fileInfo.Exists);
            if (fileInfo.Exists)
            {
                Console.WriteLine("FullName: " + fileInfo.FullName);
                //string s = fileInfo.FullName;
                Console.WriteLine("Name: " + fileInfo.Name);
                Console.WriteLine("DirectoryName: " + fileInfo.DirectoryName);
                Console.WriteLine("Extension: " + fileInfo.Extension);
                Console.WriteLine("Length: " + fileInfo.Length + " bytes");
                Console.WriteLine("LastWriteTime: " + fileInfo.LastWriteTime);
                Console.WriteLine("LastAccessTime: " + fileInfo.LastAccessTime);
                Console.WriteLine("CreationTime: " + fileInfo.CreationTime);
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadKey();
        }
    }
}
