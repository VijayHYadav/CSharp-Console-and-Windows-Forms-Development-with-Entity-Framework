using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExpExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("^[A-Za-z ]*$"); //for digit only => "^[0-9]*$"
            Console.WriteLine("Enter a name: ");
            string inputValue = Console.ReadLine();
            bool result = regex.IsMatch(inputValue);
            Console.WriteLine(result);
            if (result == true)
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Invalid name");
            }
            Console.ReadKey();
        }
    }
}
