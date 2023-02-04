using System;
using System.Collections.Generic;

namespace IEnumerableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<string> message = new List<string>() { "hello", "hey", "hi", "hie" };
            IEnumerable<string> messages = new List<string>() { "hello", "hey", "hi", "hie" };

            foreach (var item in messages)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n IEnumerator:");
            IEnumerator<string> enumerator = messages.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
    }
}
