using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshaBank.Configuration
{
    /// <summary>
    /// Project level configuration settings
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Customer number stats from 1001; incremented by 1
        /// </summary>
        public static long BaseCustomerNo { get; set; } = 1000;
    }
}
