using HarshaBank.Entities.Contracts;
using HarshaBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshaBank.Entities
{
    /// <summary>
    /// Represents customer of the bank
    /// </summary>
    public class Customer: ICustomer
    {
        #region Private fields
        private Guid _customerId;
        private long _customerCode;
        private string _customerName;
        private string _address;
        private string _landmark;
        private string _city;
        private string _country;
        private string _mobile;
        #endregion

        #region Public Properties
        /// <summary>
        /// Guid of Customer for Unique identification.
        /// </summary>
        public Guid CustomerId { get => _customerId; set => _customerId = value; }
        /// <summary>
        /// CustomerCode.
        /// </summary>
        public long CustomerCode { 
            get => _customerCode; 
            set
            {
                if (value > 0)
                {
                    _customerCode = value;
                } else
                {
                    throw new Exception("Customer code should be positive only.");
                }
            }
        }
        /// <summary>
        /// CustomerName.
        /// </summary>
        public string CustomerName { 
            get => _customerName; 
            set {
                // customer name should be less then 40 character
                if (value.Length < 40 && string.IsNullOrEmpty(value) == false)
                {
                    _customerName = value;
                } else
                {
                    throw new CustomerException("Customer Name should not be null and less than 40 char long.");
                }
            }
        }
        /// <summary>
        /// Address.
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        /// <summary>
        /// Landmark.
        /// </summary>
        public string Landmark { get => _landmark; set => _landmark = value; }
        /// <summary>
        /// Country.
        /// </summary>
        public string Country { get => _country; set => _country = value; }
        /// <summary>
        /// Mobile.
        /// </summary>
        public string Mobile
        {
            get => _mobile;
            set
            {
                // mobile number should be 10 char long.
                if (value.Length == 10)
                {
                    _mobile = value;
                }
                else
                {
                    throw new Exception("Mobile number should 10-digit number");
                }
            }
        }
        /// <summary>
        /// City.
        /// </summary>
        public string City { get => _city; set => _city = value; }
        #endregion
    }
}
