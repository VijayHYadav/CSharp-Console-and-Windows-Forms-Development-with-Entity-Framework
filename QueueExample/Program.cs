using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<String> queue = new Queue<String>();

            queue.Enqueue("a");
            queue.Enqueue("b"); 
            queue.Enqueue("c");
            queue.Enqueue("d");

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }

            queue.Dequeue();
            queue.Dequeue();

            System.Console.WriteLine();

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine();

            System.Console.WriteLine(queue.Peek());
        }
    }
}
