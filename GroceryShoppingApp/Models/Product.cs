using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShoppingApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string  Catergory { get; set; }
        public int Quatity { get; set; }
        public double Discount { get; set; }
        public string Seller { get; set; }
        public int Rating { get; set; }

    }
}
