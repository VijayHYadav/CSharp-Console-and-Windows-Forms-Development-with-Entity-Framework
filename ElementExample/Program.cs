using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementExample
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
                new Employee() { EmpID = 7, Name="Renry", Job="OpsSec", City="NY"},
                new Employee() { EmpID = 8, Name="Renry", Job="OpsSec", City="NY"},
                new Employee() { EmpID = 9, Name="Renry", Job="OpsSec", City="NY"},
            };

            Employee filteredEmployees = employees.Where(emp => emp.Job == "OpsSec").ElementAt(1);
            
            Console.WriteLine(filteredEmployees.EmpID +" , "+ filteredEmployees.Job);

            Employee filteredEmployees2 = employees.Where(emp => emp.Job == "OpsSec").ElementAtOrDefault(1);
            if (filteredEmployees2 != null)
            {
                Console.WriteLine(filteredEmployees2.EmpID + " , " + filteredEmployees2.Job);
            }

        }
    }
}
