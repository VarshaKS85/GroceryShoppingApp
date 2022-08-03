using GroceryShoppingApp.Interfaces;
using GroceryShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GroceryShoppingApp.Service
{
    public class Customer : ICustomer
    {
        private GroceryApp grocery;
        public Customer(GroceryApp grocery)
        {
            this.grocery = grocery;
        }
        public Inventory viewInventory()
        {
           var res= this.grocery.showInventory();
            return res;
        }

        public void addProductsToCart(Product prod)
        {
            Cart cart = new Cart();
            cart.product.Add(prod);
            grocery.removeProductFromInventory(prod);
            
        }
    }
}
