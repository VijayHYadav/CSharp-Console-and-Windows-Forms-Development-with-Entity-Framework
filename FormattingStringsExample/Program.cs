using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingStringsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string director = "Sam Raimi", movie = "Spider man";
            string formatedString = string.Format("{0} is the director of {1}", director, movie);
            string formatedString2 = $"{director} is the director of {movie}";
            Console.WriteLine(formatedString);
            Console.WriteLine(formatedString2);
        }
    }
}
