using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Student
    {
        public int Mark { get; set; }
        public int Rank { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack<Student> marks = new Stack<Student>();

            marks.Push(new Student() { Mark = 45 });
            marks.Push(new Student() { Mark = 55 });
            marks.Push(new Student() { Mark = 65 });
            marks.Push(new Student() { Mark = 75 });

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("After Pushing...");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            int r = 1;

            foreach (var item in marks)
            {
                item.Rank = r;
                Console.WriteLine(item.Mark + " :: " + item.Rank);
                r++;
            }

            Console.WriteLine();

            stack.Pop();
            stack.Pop();

            Console.WriteLine("After Poping...");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
