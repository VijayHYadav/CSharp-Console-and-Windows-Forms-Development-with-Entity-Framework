using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
    }

    class Temporary
    {
        public bool Check(Employee emp)
        {
            return emp.Job == "OpsSec";
        }
    }

    internal class Program
    {
        static void Main()
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

            // IEnumerable<Employee> is type of Where() method
            var result = employees.Where(emp => emp.Job == "OpsSec");
            foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpID + " : " + item.Name + " : " + item.Job + "  : " + item.City);
            }
        }
    }
}
