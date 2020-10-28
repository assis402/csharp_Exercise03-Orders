using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace csharp_Exercise03_Orders.Entities
{
    class OrderItem
    {
        public int Quantify { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantify, double price)
        {
            Quantify = quantify;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantify * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantify: " + Quantify
                + ", Subtotal:" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
