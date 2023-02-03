using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashsetExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> emp2021 = new HashSet<string>()
            {
                "Scott", "smith", "Allen"
            };

            HashSet<string> emp2022 = new HashSet<string>()
            {
                "smith", "Allen", "Rohan", "Vikas", "Raju"
            };

            emp2021.IntersectWith(emp2022);

            foreach (var item in emp2021)
            {
                Console.WriteLine(item);
            }
        }
    }
}
