using ClassLibrary8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object
            Customer customer= new Customer();

            // get details
            (int customerId, string customerName, string email) cust = customer.GetCustomerDetails();

            Console.WriteLine(cust.customerId);
            Console.WriteLine(cust.customerName);
            Console.WriteLine(cust.email);

            Console.WriteLine("===");

            // get details
            (int customerId, string customerName, string email) = customer.GetCustomerDetails();

            Console.WriteLine(customerId);
            Console.WriteLine(customerName);
            Console.WriteLine(email);
        }
    }
}
