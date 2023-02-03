using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intCollection = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<string> strCollection = intCollection.ConvertAll<string>((n) =>
            {
                string word;
                switch (n)
                {
                    case 1: word = "One"; break;
                    case 2: word = "Two"; break;
                    case 3: word = "Three"; break;
                    case 4: word = "Four"; break;
                    case 5: word = "Five"; break;
                    case 6: word = "Six"; break;
                    case 7: word = "Seven"; break;
                    default: word = ""; break;
                }

                return word;
                // string convertedStringValue = n.ToString();
                // return Convert.ToString(n);
            });

            //print the result sstg
            foreach (string item in strCollection)
            {
                Console.WriteLine("item :: " + item);
            }

            Console.ReadLine();
        }
    }
}
