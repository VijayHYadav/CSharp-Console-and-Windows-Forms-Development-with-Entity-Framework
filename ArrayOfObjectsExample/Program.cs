using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ArrayOfObjectsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id= 1, Name= "Vijay" };
            Employee employee2 = new Employee() { Id= 2, Name= "Jay" };
            Employee employee3 = new Employee() { Id= 3, Name= "sanjay" };

            Employee[] empArray = new Employee[] { employee1, employee2, employee3 };

            foreach(Employee emp in empArray )
            {
                Console.WriteLine( emp.Id );
                Console.WriteLine( emp.Name );
            }

            Console.ReadKey();
        }
    }
}
