using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"d:\practice\japan.txt";
            string destPath = @"d:\practice\another.txt";
            string destPath2 = @"d:\practice\somethingelse.txt";

            FileInfo fileInfo = new FileInfo(filePath);

            //Create()
            fileInfo.Create().Close();
            Console.WriteLine("japan.txt created");

            //CopyTo()
            FileInfo fileInfo2 = fileInfo.CopyTo(destPath, true); // true for overide
            Console.WriteLine(fileInfo2.Name + " created");

            //MoveTo()
            fileInfo2.MoveTo(destPath2);
            Console.WriteLine(fileInfo2.Name + " moved");

            //Delete()
            fileInfo2.Delete();
            Console.WriteLine(fileInfo2.Name + " deleted");
            Console.ReadKey();
        }
    }
}
