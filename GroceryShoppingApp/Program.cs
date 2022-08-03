using GroceryShoppingApp.Models;
using GroceryShoppingApp.Service;
using System;

namespace GroceryShoppingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inv = new Inventory();
            inv.products.Add(new Product { Name = "Coke", Catergory = "Beverage", Quatity = 7, Discount = 0, Rating = 5, Seller = "Pepsi" });
            GroceryApp grocery = new GroceryApp(inv);

            Customer cust = new Customer(grocery);
            var inventoryAfterBefore = cust.viewInventory();
            Product prod = new Product { Name = "Coke", Catergory = "Beverage", Quatity = 1, Discount = 0, Rating = 5, Seller = "Pepsi" };
            cust.addProductsToCart(prod);
            var inventoryAfterAdd= cust.viewInventory();

            Seller sel = new Seller(grocery);
            Product addProd = new Product { Name = "Coke", Catergory = "Beverage", Quatity = 1, Discount = 0, Rating = 5, Seller = "Pepsi" };
            Console.WriteLine(sel.addProductsToInvertory(addProd));
        }
    }
}
