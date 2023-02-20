using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingStringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Developer";
            Console.WriteLine(str); // Output:
            
            Console.WriteLine(str.ToUpper()); // Output:
            Console.WriteLine(str.ToLower()); // Output:
            Console.WriteLine(str);

            Console.WriteLine(str.Substring(2));
            Console.WriteLine(str.Substring(2, 4));

            string str_rpl = str.Replace("e", "x");
            Console.WriteLine("Replaced: "+str_rpl);

            string message = "how are you";
            string[] words = message.Split(' ');
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            string message_with_space = " hello ";
            Console.WriteLine(message_with_space.Trim());

            char[] characters = str.ToCharArray();
            foreach (var item in characters)
            {
                Console.WriteLine(item);
            }

            string[] my_words = new string[] { "how", "are", "you" };// how-are-you
            Console.WriteLine(string.Join("-", my_words));

            char[] chars = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string str2 = new string(chars);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
