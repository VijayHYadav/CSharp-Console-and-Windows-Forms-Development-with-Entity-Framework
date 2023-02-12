using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary8
{
    public class Customer
    {
        public (int customerId, string customerName, string email) GetCustomerDetails()
        {
            return (786, "Scott", "Scott@gmail.com");
        }
    }
}
