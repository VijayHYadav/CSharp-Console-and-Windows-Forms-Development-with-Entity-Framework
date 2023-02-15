using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.BALContracts;
using HarshaBank.DataAccessLayer;
using HarshaBank.DataAccessLayer.Contracts;
using HarshaBank.Entities;
using HarshaBank.Exceptions;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Represents customer business logic
    /// </summary>
    public class CustomersBusinessLogicLayer: ICustomersBusinessLogicLayer
    {
        #region Private Fields
        private ICustomersDataAccessLayer _customersDataAccessLayer;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor that initializes CustomersDataAccesslayer
        /// </summary>
        public CustomersBusinessLogicLayer() {
            _customersDataAccessLayer = new CustomerDataAccessLayer();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Private property that represents reference of CustomersDataAccessLayer
        /// </summary>
        private ICustomersDataAccessLayer CustomersDataAccessLayer
        {
            set => _customersDataAccessLayer = value;
            get => _customersDataAccessLayer;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns all exisiting
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            try
            {
                return CustomersDataAccessLayer.GetCustomers();
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
        /// Returns a set of customers that matches with specific criteria
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            //invoke DAL
            try
            {
                return CustomersDataAccessLayer.GetCustomersByCondition(predicate);
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
        /// Adds a new customer to the existing customer list
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns true, that indicates</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                // get all customers
                List<Customer> allCustomers = CustomersDataAccessLayer.GetCustomers();
                long maxCustCode = 0;
                foreach (var item in allCustomers)
                {
                    if(item.CustomerCode > maxCustCode)
                    {
                        maxCustCode = item.CustomerCode;
                    }
                }
                // generate new customer no
                if(allCustomers.Count >= 1)
                {
                    customer.CustomerCode = maxCustCode + 1;
                } else
                {
                    customer.CustomerCode = HarshaBank.Configuration.Settings.BaseCustomerNo + 1;
                }

                //invoke DAL
                return CustomersDataAccessLayer.AddCustomer(customer);
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
        /// Updates an existing
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update</param>
        /// <returns>Returns true, that indicates the customer is updated successfully</returns>
        public bool UpdateCustomer(Customer customer)
        {
            //invoke DAL
            try
            {
                return CustomersDataAccessLayer.UpdateCustomer(customer);
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
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerID">CustomerID to delete</param>
        /// <returns>Returns true, that indicates the customer is delete successfully</returns>
        public bool DeleteCustomer(Guid customerID)
        {
            //invoke DAL
            try
            {
                return CustomersDataAccessLayer.DeleteCustomer(customerID);
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
