using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"d:\practice\dog.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.Create(filePath);
            //FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.OpenWrite(filePath);
            //FileStream fileStream = fileInfo.Create();
            FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);
            //FileStream fileStream = fileInfo.OpenWrite();

            //create content
            string content = "Vijay is one of the domestic animal.";
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(content);

            //Write
            fileStream.Write(bytes, 0, bytes.Length);
            //some work here
            string content2 = "other text here";
            byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(content2);
            fileStream.Write(bytes2, 0, bytes2.Length);

            fileStream.Close();
            Console.WriteLine("dog.txt created");

            Console.ReadKey();
        }
    }
}
