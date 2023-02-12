using ClassLibrary7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            var person = new {PersonName = p.GetPersonName(), Age = p.GetPersonAge(), Address = new { Street="abc", City="xyz" } };

            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address.Street);
            Console.WriteLine(person.Address.City);
        }
    }
}
