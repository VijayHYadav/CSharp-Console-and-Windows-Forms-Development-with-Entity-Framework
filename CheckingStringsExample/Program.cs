using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingStringsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Universe";
            string str2 = "Universe";

            bool eq = str.Equals(str2);
            bool eq2 = str == str2;

            Console.WriteLine(eq);
            Console.WriteLine(eq2);

            bool sw = str.StartsWith("U");
            Console.WriteLine(sw);
            bool sw2 = str.StartsWith("e");
            Console.WriteLine(sw2);

            Console.WriteLine(str.EndsWith("U"));
            Console.WriteLine(str.EndsWith("e"));

            Console.WriteLine(str.Contains("U"));
            Console.WriteLine(str.Contains("X"));

            string name = "developer";

            Console.WriteLine(name.IndexOf('e'));
            Console.WriteLine(name.IndexOf("lop"));
            Console.WriteLine(name.IndexOf("l"));
            Console.WriteLine(name.IndexOf("lx"));
            Console.WriteLine(name.IndexOf("x"));
            Console.WriteLine(name.IndexOf("e", 5)); // prev start index + 1
            Console.WriteLine(name.IndexOf("e", 1)); // prev start index + 1
            Console.WriteLine(name.IndexOf("e", 3)); // prev start index + 1
            Console.WriteLine(name.IndexOf("e", 0)); // prev start index + 1

            Console.ReadLine();
        }
    }
}
