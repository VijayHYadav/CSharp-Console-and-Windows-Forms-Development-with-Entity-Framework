using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class Sample
    {
        public int GetNumber()
        {
            return 10;
        }

        public double GetAnotherNumber()
        {
            return 10.7;
        }

        public string GetMessage() {

            return "Hello";
        }

        public Employee GetEmp()
        {
            Employee emp = new Employee();
            emp.EmpName = "Rocky";
            return emp;
        }
    }

    class Employee
    {
        public string EmpName { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sample sm= new Sample();
            ArrayList list = new ArrayList() { sm.GetNumber(), sm.GetAnotherNumber(), sm.GetEmp(), sm.GetMessage() };

            foreach (var i in list)
            {
                if (i is Employee emp)
                {
                    Console.WriteLine(emp.EmpName);
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
