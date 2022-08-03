using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShoppingApp.Models
{
    public class User
    {
        public string Name { get; set; }
        public int userId { get; set; }
        public string email { get; set; }
        public string orderHistory { get; set; }

        public Cart cart { get; set; }

    }
}
