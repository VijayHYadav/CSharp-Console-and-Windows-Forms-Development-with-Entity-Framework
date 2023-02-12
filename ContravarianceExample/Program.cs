using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContravarianceExample
{

    class LivingThing
    {
        public int NumberOfLegs { get; set; }

    }

    class Dog : LivingThing { }

    class Parrot : LivingThing { }

    interface IMover<in T>
    {
        void Move(T x);
    }

    public class Mover<T> : IMover<T>
    {
        public void Move(T x) {
            if (x is Parrot)
            {
                Console.WriteLine("Moving with "+(x as Parrot).NumberOfLegs + " legs");
            } else
            {
                Console.WriteLine("Moving with " + (x as Dog).NumberOfLegs + " legs");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create normal object
            Parrot parrot = new Parrot() { NumberOfLegs =2};
            Dog dog = new Dog() { NumberOfLegs = 4 };

            IMover<Parrot> obj1 = new Mover<Parrot>(); // normal
            // Contravariance = supply the parent type name, where the child type name is expected.
            IMover<Parrot> obj2 = new Mover<LivingThing>();
            //"Parrot" vs "LivingThing"; supplying the parent type (Living Thing), where the child type(Parrot) is expected.
            obj2.Move(parrot);

            IMover<Dog> obj3 = new Mover<LivingThing>();
            obj3.Move(dog);

            // Covariance allows you to supply child type, where the parent type is expected.
            // Contravariance allows you to supply parent type, where the child type is expected.
        }
    }
}