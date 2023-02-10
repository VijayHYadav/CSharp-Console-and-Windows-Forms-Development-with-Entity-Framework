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

    public enum SortBy
    {
        EmpID, EmpName, Job
    }

    class CustomComparer : IComparer<Employee>
    {
        /* public int Compare(Employee x, Employee y)
        {
            // String
            // return x.Name.CompareTo(y.Name);
            // Int
             return x.Id - y.Id;
        }*/

        /* public int Compare(Employee x, Employee y)
        {
            int result = 0;
            if(x.Job != null)
            {
                result = x.Job.CompareTo(y.Job);
            }

            if (result == 0)
            {
                if (x.Name != null)
                {
                    result = x.Name.CompareTo(y.Name);
                }
            }

            return result;
        }*/

        //Sort by selected column
        public int Compare(Employee x, Employee y)
        {
            int result = 0;
            switch (this.sortBy)
            {
                case SortBy.EmpID:
                    result = x.Id - y.Id; break;
                case SortBy.EmpName:
                    result = (x.Name != null) ? x.Name.CompareTo(y.Name) : 0; break;
                case SortBy.Job:
                    result = (x.Job != null) ? x.Job.CompareTo(y.Job) : 0; break;
                default:
                    result = 0; break;
            }
            return result;
        }

        public SortBy sortBy { get; set; }

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
                },
                new Employee()
                {
                    Id = 4,
                    Name= "Best",
                    Job= "Dev"
                },
                new Employee()
                {
                    Id = 5,
                    Name= "Gest",
                    Job= null
                }
            };

            CustomComparer customComparer = new CustomComparer();
            customComparer.sortBy = SortBy.EmpName;

            employees.Sort(customComparer);
            //employees.Reverse();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Id + employee.Name);
            }
        }
    }
}
