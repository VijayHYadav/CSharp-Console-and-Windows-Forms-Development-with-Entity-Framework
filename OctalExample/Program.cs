using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctalExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dec1 = 289;
            string oct1 = Convert.ToString(dec1, 8); //decimal to octal
            Console.WriteLine(oct1);

            int dec2 = Convert.ToInt32(oct1, 8); //octal to decimal
            Console.WriteLine(dec2);

            Console.ReadKey();
        }
    }
}
