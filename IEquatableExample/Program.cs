using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableExample
{
    public enum TypeOfCustomer
    {
        RegularCustomer, VIPCustomer
    }

    public class Customer: IEquatable<Customer>
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public TypeOfCustomer CustomerType { get; set; }

        public bool Equals(Customer other)
        {
            return this.CustomerID == other.CustomerID && this.CustomerName == other.CustomerName &&
                this.Email == other.Email && this.CustomerType == other.CustomerType;
        }
    }

    //cust collection class
    public class CustomerList : IList<Customer>
    {
        private List<Customer> customer = new List<Customer>()
        {
            new Customer() {CustomerID="A101", CustomerName="James", Email="james@example.com", CustomerType=TypeOfCustomer.RegularCustomer},
            new Customer() {CustomerID="A102", CustomerName="Shawn", Email="Shawn@example.com", CustomerType=TypeOfCustomer.VIPCustomer},
            new Customer() {CustomerID="A103", CustomerName="John", Email="John@example.com", CustomerType=TypeOfCustomer.VIPCustomer}
        };

        public int Count => customer.Count;

        public bool IsReadOnly => false;

        public Customer this[int index]
        {
            get => customer[index];
            set => customer[index] = value;
        }

        // implementing IEnumerable.GetEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            /* for (int i = 0; i < customer.Count; i++)
            {
                yield return customer[i];
            } */
            return this.GetEnumerator();
        }

        // implementing IEnumerable<T>.GetEnumerator
        public IEnumerator<Customer> GetEnumerator()
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
            if (cust.CustomerID.StartsWith("A") || cust.CustomerID.StartsWith("a"))
            {
                customer.Add(cust);
            }
            else
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }

        public void Clear()
        {
            customer.Clear();
        }

        public bool Contains(Customer item)
        {
            return customer.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            customer.CopyTo(array, arrayIndex);
        }

        public bool Remove(Customer item)
        {
            return customer.Remove(item);
        }

        public Customer Find(Predicate<Customer> match)
        {
            return customer.Find(match);
        }

        public List<Customer> FindAll(Predicate<Customer> match)
        {
            return customer.FindAll(match);
        }

        public int IndexOf(Customer item)
        {
            return customer.IndexOf(item);
        }

        public void Insert(int index, Customer item)
        {
            if (index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                customer.Insert(index, item);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Invalid Index");
            }
            else
            {
                customer.RemoveAt(index);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerList customerLists = new CustomerList();

            Customer new_cust = new Customer()
            {
                CustomerID = "A456",
                CustomerName = "Shiva",
                Email = "shiva@gmail.com",
                CustomerType = TypeOfCustomer.VIPCustomer
            };

            customerLists.Add(new_cust);
            // Contains
            Console.WriteLine("Contains1: " + customerLists.Contains(new_cust));
            Console.WriteLine();

            Customer another_cust = new Customer()
            {
                CustomerID = "A456",
                CustomerName = "Shiva",
                Email = "shiva@gmail.com",
                CustomerType = TypeOfCustomer.VIPCustomer
            };

            // Contains
            Console.WriteLine("Contains2: " + customerLists.Contains(another_cust));
            Console.WriteLine();

            Console.WriteLine(customerLists.Count + " customers found.");

            // customerList.Clear();
            // Console.WriteLine(customerList.Count + " customers found.");

            // Remove
            customerLists.Remove(new_cust);

            // Insert
            customerLists.Insert(2, new_cust);
            Console.WriteLine(customerLists[2].CustomerID + "," + customerLists[2].CustomerName);

            //IndexOf
            Console.WriteLine("IndexOf:" + customerLists.IndexOf(new_cust));

            // Find
            Customer matchingCustomer = customerLists.Find(cust => cust.CustomerID == "A101");

            if (matchingCustomer != null)
            {
                Console.WriteLine(matchingCustomer.CustomerID + " : " + matchingCustomer.CustomerName);
            }

            Console.WriteLine();

            //FindAll
            List<Customer> vipcust = customerLists.FindAll(cust => cust.CustomerType == TypeOfCustomer.VIPCustomer);

            Console.WriteLine("VIP-Customer Start");

            // VIPCust
            foreach (Customer customer in vipcust)
            {
                Console.WriteLine(customer.CustomerID + " : " + customer.CustomerName + " : " + customer.CustomerType);
            }

            Console.WriteLine("VIP-Customer End");

            IEnumerator enumerator = customerLists.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(((Customer)enumerator.Current).CustomerID);


            Console.WriteLine();


            foreach (Customer customer in customerLists)
            {
                Console.WriteLine(customer.CustomerID + customer.CustomerName + customer.CustomerType);
            }
        }
    }
}
