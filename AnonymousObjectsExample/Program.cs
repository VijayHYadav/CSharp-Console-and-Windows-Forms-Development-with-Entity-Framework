using ClassLibrary7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousObjectsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();

            p.GetPersonName();
            p.GetPersonAge();

            var person = new { PersonName = p.GetPersonName(), PersonAge = p.GetPersonAge() };

            Console.WriteLine(person.PersonAge);
            Console.WriteLine(person.PersonName);
        }
    }
}
