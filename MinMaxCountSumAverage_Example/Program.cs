using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxCountSumAverage_Example
{
    class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string City { get; set; }

        public double Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 1, Name="Henry", Job="Dev", City="Boston", Salary=20000},
                new Employee() { EmpID = 2, Name="Jenry", Job="DevOps", City="New Boston", Salary=30000},
                new Employee() { EmpID = 3, Name="Cenry", Job="DevSec", City="Sanfran cisco", Salary = 40000},
                new Employee() { EmpID = 4, Name="Tenry", Job="OpsSec", City="Old Boston", Salary = 50000},
                new Employee() { EmpID = 5, Name="Genry", Job="Developer", City="Tokyo", Salary = 20000},
                new Employee() { EmpID = 6, Name="Renry", Job="OpsSec", City="NY", Salary = 60000},
                new Employee() { EmpID = 7, Name="Renry", Job="OpsSec", City="NY", Salary = 70000},
                new Employee() { EmpID = 8, Name="Renry", Job="OpsSec", City="NY", Salary = 70000},
                new Employee() { EmpID = 9, Name="Renry", Job="OpsSec", City="NY", Salary = 90000},
            };

            double sumSalary = employees.Sum(emp => emp.Salary);
            Console.WriteLine(sumSalary);
            double minSalary = employees.Min(emp => emp.Salary);
            Console.WriteLine(minSalary);
            double maxSalary = employees.Max(emp => emp.Salary);
            Console.WriteLine(maxSalary);
            double avgSalary = employees.Average(emp => emp.Salary);
            Console.WriteLine(avgSalary);
            double cntSalary = employees.Count();
            Console.WriteLine(cntSalary);
        }
    }
}
