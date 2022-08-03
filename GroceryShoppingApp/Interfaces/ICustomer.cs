using GroceryShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShoppingApp.Interfaces
{
    public interface ICustomer
    {
        Inventory viewInventory();

        void addProductsToCart(Product prod);
    }
}
