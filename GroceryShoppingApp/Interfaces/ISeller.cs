using GroceryShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShoppingApp.Interfaces
{
    public interface ISeller
    {
        //Seller Adds products
        bool addProductsToInvertory(Product prod);
    }
}
