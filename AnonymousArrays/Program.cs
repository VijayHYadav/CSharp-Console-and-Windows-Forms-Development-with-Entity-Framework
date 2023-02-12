using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create anonymous arrya / implicitly typed array
            var persons = new[] { 
                new {PersonName = "Scott", Email = "Scott@gmail.com"},
                new {PersonName = "Tom", Email = "Tom@gmail.com"},
                new {PersonName = "Jack", Email = "Jack@gmail.com"},
                new {PersonName = "Matt", Email = "Matt@gmail.com"}
            };

            foreach (var item in persons)
            {
                Console.WriteLine(item.PersonName + item.Email);
            }
        }
    }
}
