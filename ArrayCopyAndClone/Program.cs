using System;

// Clone and CopyTo are both shallow coping way
namespace ArrayCopyAndClone
{
    // model class
    class Employee
    {
        public string EmployeeName { get; set; }
        public string Role { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee(){EmployeeName="vijay", Role="Developer"},
                new Employee(){EmployeeName="vizz", Role="Hacker"},
                new Employee(){EmployeeName="tom", Role="Debugger"}
            };

            // new array
            Employee[] highlyPaidEmployees = new Employee[5];

            // copyTo
            employees.CopyTo(highlyPaidEmployees, 0);

            foreach (Employee employee in highlyPaidEmployees)
            {
                if(!(employee is null))
                {
                    Console.WriteLine(employee.EmployeeName + " : " + employee.Role);
                } else
                {
                    Console.WriteLine("null object");
                }
            }


            //Clone
            Employee[] highlyPaidEmployees2 = (Employee[])employees.Clone();

            Console.WriteLine("\nClone:");
            foreach(Employee emp in highlyPaidEmployees2)
            {
                if (!(emp is null))
                {
                Console.WriteLine(emp.EmployeeName+ " : " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            } 

            Console.ReadKey();
        }
    }
}
