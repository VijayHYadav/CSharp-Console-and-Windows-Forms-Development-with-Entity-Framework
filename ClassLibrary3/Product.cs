using System;
using System.Collections.Generic;

namespace ECommerce
{
    /// <summary>
    ///     Represents a Product in ECommerce application 
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }

        public DateTime DateOfManufacture { get; set; }
    }
}
