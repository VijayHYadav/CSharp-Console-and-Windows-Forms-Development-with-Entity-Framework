using System;

namespace DeepCopyExample
{
    // model class
    class Employee:System.ICloneable
    {
        public string EmployeeName { get; set; }
        public string Role { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                EmployeeName= this.EmployeeName,
                Role= this.Role
            };
        }
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

            // deep copy
            Employee[] employees_deep_copy = new Employee[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                employees_deep_copy[i] = (Employee)employees[i].Clone();
            }

            // new array
            Employee[] highlyPaidEmployees = new Employee[5];

            // copyTo
            employees.CopyTo(highlyPaidEmployees, 0);

            foreach (Employee employee in highlyPaidEmployees)
            {
                if (!(employee is null))
                {
                    Console.WriteLine(employee.EmployeeName + " : " + employee.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }


            //Clone
            Employee[] highlyPaidEmployees2 = (Employee[])employees.Clone();

            Console.WriteLine("\nClone:");
            foreach (Employee emp in highlyPaidEmployees2)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(emp.EmployeeName + " : " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            // Deep Copy:
            Console.WriteLine("\n Deep Copy");
            foreach (var emp in employees_deep_copy)
            {
                Console.WriteLine(emp.EmployeeName + " : " + emp.Role);
            }
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
