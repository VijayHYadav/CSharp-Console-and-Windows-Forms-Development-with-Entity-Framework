using System;

namespace HelloWorld.NET5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.cutomerId= 1;
            customer.name= "vijay";

            System.Console.WriteLine(customer.cutomerId);
            System.Console.WriteLine(customer.name);
            System.Console.ReadKey();
        }
    }
}
