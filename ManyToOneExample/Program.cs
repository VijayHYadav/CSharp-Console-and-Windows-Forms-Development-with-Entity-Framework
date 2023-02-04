using ClassLibrary6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToOneExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp employee1 = new Emp() { EmployeeId = 1, EmployeeName = "john", Email="john@gmail.com"};
            Emp employee2 = new Emp() { EmployeeId = 2, EmployeeName = "mac", Email = "mac@gmail.com" };
            Emp employee3 = new Emp() { EmployeeId = 3, EmployeeName = "brock", Email = "brock@gmail.com" };

            Dept department = new Dept() { Id = 10, Name="Accounting" };

            employee1.dept= department;
            employee2.dept= department;
            employee3.dept= department;

            Console.WriteLine(employee1.EmployeeId +":"+ employee1.EmployeeName +":"+ employee1.Email +":"+ employee1.dept.Name);
            Console.WriteLine(employee2.EmployeeId + ":" + employee2.EmployeeName + ":" + employee2.Email + ":" + employee2.dept.Name);
            Console.WriteLine(employee3.EmployeeId + ":" + employee3.EmployeeName + ":" + employee3.Email + ":" + employee3.dept.Name);
        }
    }
}
