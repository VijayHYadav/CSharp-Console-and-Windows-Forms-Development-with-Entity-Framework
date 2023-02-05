using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public enum TypeOfCustomer
    {
        RegularCustomer, VIPCustomer
    }

    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public TypeOfCustomer CustomerType { get; set; }
    }

    //cust collection class
    public class CustomerList:IEnumerable
    {
        private List<Customer> customer = new List<Customer>()
        {
            new Customer() {CustomerID="A101", CustomerName="James", Email="james@example.com", CustomerType=TypeOfCustomer.RegularCustomer},
            new Customer() {CustomerID="A102", CustomerName="Shawn", Email="Shawn@example.com", CustomerType=TypeOfCustomer.VIPCustomer},
            new Customer() {CustomerID="A103", CustomerName="John", Email="John@example.com", CustomerType=TypeOfCustomer.VIPCustomer}
        };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < customer.Count; i++)
            {
                yield return customer[i];
            }
        }

        // Not Good Approach
        /* public List<Customer> GetCustomer()
        {
            return customer;
        }*/

        public void Add(Customer cust)
        {
            if(cust.CustomerID.StartsWith("A") || cust.CustomerID.StartsWith("a"))
            {
                customer.Add(cust);
            } else
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerList customerList = new CustomerList();

            Customer new_cust = new Customer() { CustomerID = "A456", CustomerName = "Shiva", Email="shiva@gmail.com",
            CustomerType=TypeOfCustomer.VIPCustomer};

            customerList.Add(new_cust);

            IEnumerator enumerator = customerList.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(((Customer)enumerator.Current).CustomerID);


            Console.WriteLine();

            foreach(Customer customer in customerList)
            {
                Console.WriteLine(customer.CustomerID + customer.CustomerName + customer.CustomerType);
            }
        }
    }
}
