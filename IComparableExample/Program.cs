using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    class Employee: IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public int CompareTo(object other)
        {
            Employee otherEmp = other as Employee;
            Console.WriteLine(this.Id + "," + otherEmp.Id);

            // for String Comparing
            // return this.Name.CompareTo(otherEmp.Name);
            
            // for Int Comparing
            return this.Id - otherEmp.Id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //list of numbers
            List<int> numbers = new List<int>() { 80, 12, 77, 34};
            numbers.Sort();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //list of employees
            List<Employee> employees= new List<Employee>()
            {
                new Employee() { Id=4, Name="Larry", Job="DevSecOps"},
                new Employee() { Id=1, Name="Mary", Job="Dev"},
                new Employee() { Id=3, Name="Carry", Job="DevSec"},
                new Employee() { Id=2, Name="Harry", Job="DevOps"},
            };

            System.Console.WriteLine();

            foreach (var item in employees)
            {
                System.Console.WriteLine(item.Id + " : " + item.Name + " : " + item.Job);
            }

            System.Console.WriteLine();

            employees.Sort();

            foreach (var item in employees)
            {
                System.Console.WriteLine(item.Id +" : "+ item.Name + " : " + item.Job);
            }

            Console.ReadKey();
        }
    }
}
