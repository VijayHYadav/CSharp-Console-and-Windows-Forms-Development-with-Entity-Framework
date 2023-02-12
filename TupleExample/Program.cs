using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{

    class Sample
    {
        public Tuple<string, int> GetPersonDetails()
        {
            Tuple<string, int> person = new Tuple<string, int>("Scott", 100);

            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a new Tuple that stores person name and age.
            Tuple<string, int> person = new Tuple<string, int>("Scott", 20);

            //access values from tuple
            Console.WriteLine(person.Item1); //Scott
            Console.WriteLine(person.Item2); //20

            Sample s = new Sample();
            Tuple<string, int> personDetails = s.GetPersonDetails();

            Console.WriteLine(personDetails.Item1);
            Console.WriteLine(personDetails.Item2);

            Console.ReadKey();
        }
    }
}
