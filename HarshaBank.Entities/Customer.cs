using HarshaBank.Entities.Contracts;
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
        public long CustomerCode { get => _customerCode; set => _customerCode = value; }
        /// <summary>
        /// CustomerName.
        /// </summary>
        public string CustomerName { get => _customerName; set => _customerName = value; }
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
        public string Mobile { get => _mobile; set => _mobile = value; }
        /// <summary>
        /// City.
        /// </summary>
        public string City { get => _city; set => _city = value; }
        #endregion
    }
}
