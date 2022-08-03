using GroceryShoppingApp.Interfaces;
using GroceryShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShoppingApp.Service
{
    public class Seller: ISeller
    {
        private GroceryApp grocery;
        public Seller(GroceryApp grocery)
        {
            this.grocery = grocery;
        }
        public bool addProductsToInvertory(Product prod)
        {
            if (prod != null)
            {
                grocery.addProductsToInvertory(prod);
                return true;
            }
            return false;

        }
    }
}
