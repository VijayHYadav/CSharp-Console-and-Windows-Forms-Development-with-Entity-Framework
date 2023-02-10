using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceExample
{
    class LivingThing
    {
        public int NumberOfLegs { get; set; }
    }

    class Parrot:LivingThing
    {

    }

    class Dog : LivingThing
    {

    }

    interface IMover<out T>
    {
        T Move();
    }

    class Mover<T>:IMover<T>
    {
        public T thing { get; set; }

        public T Move()
        {
            return thing;
        }
    }

    class Sample
    {
        public void PrintValues(IEnumerable<object> values)
        {
            foreach (var item in values)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // create object
            LivingThing livingThing =  new Parrot(); //not covariance.
            Parrot parrot = new Parrot() { NumberOfLegs = 4 }; //normal

            // Covariance = supply the child type name, where the parent type name is expected.
            IMover<LivingThing> mover = new Mover<Parrot>() { thing = parrot};
            Console.WriteLine("NumberOfLegs: " + mover.Move().NumberOfLegs);

            // Covariance in real life
            Sample s = new Sample();
            s.PrintValues(new List<string>() { "hello", "world" });


            Console.ReadKey();
        }
    }
}
