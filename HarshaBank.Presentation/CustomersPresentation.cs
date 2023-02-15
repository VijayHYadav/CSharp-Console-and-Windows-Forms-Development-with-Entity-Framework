using BusinessLogicLayer;
using BusinessLogicLayer.BALContracts;
using HarshaBank.Entities;
using HarshaBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshaBank.Presentation
{
    static class CustomersPresentation
    {
        internal static void AddCustomer()
        {
            //invoke DAL
            try
            {
                //create an object of Customer
                Customer customer = new Customer();

                //read all details from the user
                Console.WriteLine("\n******ADD CUSTOMER*****");
                Console.Write("Customer Name:");
                customer.CustomerName = Console.ReadLine();
                Console.WriteLine("Address:");
                customer.Address = Console.ReadLine();
                Console.WriteLine("City:");
                customer.City = Console.ReadLine();
                Console.WriteLine("Country");
                customer.Country = Console.ReadLine();
                Console.WriteLine("Mobile");
                customer.Mobile = Console.ReadLine();

                //create BL object
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();
                Guid newGuid = customersBusinessLogicLayer.AddCustomer(customer);
                Console.WriteLine(newGuid);
                Console.WriteLine("Customer Added\n");
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
            
        }
    }
}
