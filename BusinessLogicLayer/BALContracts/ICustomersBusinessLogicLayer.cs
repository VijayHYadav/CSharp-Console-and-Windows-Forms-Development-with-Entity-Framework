using HarshaBank.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.BALContracts
{
    /// <summary>
    /// Interface that represents customers data access layer
    /// </summary>
    public interface ICustomersBusinessLogicLayer
    {
        /// <summary>
        /// Returns all exisiting
        /// </summary>
        /// <returns></returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Returns a set of customers that matches with specific criteria
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);

        /// <summary>
        /// Adds a new customer to the existing customer list
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns true, that indicates</returns>
        Guid AddCustomer(Customer customer);

        /// <summary>
        /// Updates an existing
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update</param>
        /// <returns>Returns true, that indicates the customer is updated successfully</returns>
        bool UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerID">CustomerID to delete</param>
        /// <returns>Returns true, that indicates the customer is delete successfully</returns>
        bool DeleteCustomer(Guid customerID);
    }
}