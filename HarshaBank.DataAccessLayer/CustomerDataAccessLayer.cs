using HarshaBank.DataAccessLayer.Contracts;
using HarshaBank.Entities;
using HarshaBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshaBank.DataAccessLayer
{
    /// <summary>
    /// Represents DAL for bank customers
    /// </summary>
    public class CustomerDataAccessLayer: ICustomersDataAccessLayer
    {
        #region Fields
        private List<Customer> _customers;
        #endregion

        #region Constructors
        public CustomerDataAccessLayer()
        {
            _customers = new List<Customer>();

        }
        #endregion

        #region Properties
        /// <summary>
        /// Represents source customers collection
        /// </summary>
        private List<Customer> Customers
        {
            set => _customers = value;
            get => _customers;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>Customers list</returns>
        public List<Customer> GetCustomers()
        {

            try { 
                //create a new customers list
                List<Customer> customersList = new List<Customer>();

                // copy all customers from the source collection into the newCustomers list
                Customers.ForEach(item => customersList.Add(item.Clone() as Customer));
            return customersList;
            }
            catch(CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Returns list of customers that are matching with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression with condition</param>
        /// <returns>List of matching customer</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //create a new customers list
                List<Customer> customersList = new List<Customer>();

                //filter the collection
                List<Customer> filteredCustomers = customersList.FindAll(predicate);

                // copy all customers from the source collection into the newCustomers list
                Customers.ForEach(item => filteredCustomers.Add(item.Clone() as Customer));
                return customersList;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Adds a new customer to the exisiting list
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <returns>Returns Guid of newly created customer</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
            //generate new Guid
            customer.CustomerId = Guid.NewGuid();

            //add customer
            Customers.Add(customer);

            return customer.CustomerId;
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Updates an exisiting customer's details
        /// </summary>
        /// <param name="customer">Customer object with updated details</param>
        /// <returns>Determines whether the customer is updated or not</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {

            //find existing customer by CustomerId
            Customer existingCustomer = Customers.Find(item => item.CustomerId == customer.CustomerId);

            //update all details of customer
            if (existingCustomer != null)
            {
                existingCustomer.CustomerCode= customer.CustomerCode;
                existingCustomer.CustomerName = customer.CustomerName;
                existingCustomer.Address = customer.Address;
                existingCustomer.Landmark = customer.Landmark;
                existingCustomer.City = customer.City;
                existingCustomer.Country = customer.Country;
                existingCustomer.Mobile = customer.Mobile;

                return true; //indicates the customer is updated...
            } else
            {
                return false;
            }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing customer based on CustomerID
        /// </summary>
        /// <param name="customerId">Customer to delete</param>
        /// <returns>Indicates whether the customer is deleted or not</returns>
        public bool DeleteCustomer(Guid customerId)
        {
            try
            {
            // delete customer by CustomerId
            if(Customers.RemoveAll(item => item.CustomerId == customerId) > 0) {
                return true; // indicates one or more customers are deleted
            } else
            {
                return false; // indicates no customer is deleted
            }

            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
