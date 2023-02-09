using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerExample
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
    }

    class CustomComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            // String
            // return x.Name.CompareTo(y.Name);
            // Int
             return x.Id - y.Id;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 2,
                    Name= "Fest",
                    Job= "DevSec"
                },
                new Employee()
                {
                    Id = 1,
                    Name= "Test",
                    Job= "DevOps"
                },
                new Employee()
                {
                    Id = 3,
                    Name= "Cest",
                    Job= "Dev"
                }
            };

            CustomComparer customComparer = new CustomComparer();
            
            employees.Sort(customComparer);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Id + employee.Name);
            }
        }
    }
}
