using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 1, Name="Henry", Job="Dev", City="Boston"},
                new Employee() { EmpID = 2, Name="Jenry", Job="DevOps", City="New Boston"},
                new Employee() { EmpID = 3, Name="Cenry", Job="DevSec", City="Sanfran cisco"},
                new Employee() { EmpID = 4, Name="Tenry", Job="OpsSec", City="Old Boston"},
                new Employee() { EmpID = 5, Name="Genry", Job="Developer", City="Tokyo"},
                new Employee() { EmpID = 6, Name="Renry", Job="OpsSec", City="NY"},
            };

            List<Employee> filteredEmployees = employees.Where(emp => emp.Job == "OpsSec").ToList();

            Console.WriteLine(filteredEmployees[0].EmpID);

            Employee firstMatch = employees.First(emp => emp.Job == "OpsSec");

            Console.WriteLine(firstMatch.EmpID);

            // better to use FirstOrDefault, it will return null.
            Employee firstMatchOrDefault = employees.FirstOrDefault(emp => emp.Job == "OpsSec");

            if (firstMatchOrDefault != null)
            {
                Console.WriteLine(firstMatchOrDefault.EmpID);
            }

        }
    }
}
