using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public decimal Cost { get; set; }

        public Product (string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Cost = Price * Quantity;
        }


    }
}
