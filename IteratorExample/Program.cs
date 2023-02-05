using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public class Sample
    {
        public List<double> Prices { get; set; } = new List<double>() { 90, 34, 12, 80 };
        
        public IEnumerable<double> Method()
        {
            double sum = 0;
            foreach (double price in Prices)
            {
                sum += price;
                yield return sum; //90
            }
        }

        /*public IEnumerable<int> Method()
        {
            Console.WriteLine("Iterator method executes");
            yield return 10;
            Console.WriteLine("Iterator method executes continued");
            yield return 20;
        }*/
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            var enumerable1 = s.Method();
            var enumerator1 = enumerable1.GetEnumerator();
            
            enumerator1.MoveNext();
            Console.WriteLine(enumerator1.Current);
            
            enumerator1.MoveNext();
            Console.WriteLine(enumerator1.Current);
            
            Console.WriteLine();

            foreach (var item in enumerable1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
