using GroceryShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroceryShoppingApp
{
    public class GroceryApp
    {
        private Inventory inventory { get; set; }
        public GroceryApp(Inventory inv)
        {
            this.inventory = inv;
        }
        public Inventory showInventory()
        {
            return inventory;
        }

        public void addProductsToInvertory(Product prod)
        {
            inventory.products.Add(prod);
        }

        public void removeProductFromInventory(Product product)
        {
            var prod = inventory.products.Where(x => x.Name == product.Name).FirstOrDefault();
            prod.Quatity -= product.Quatity;
        }

    }
}
