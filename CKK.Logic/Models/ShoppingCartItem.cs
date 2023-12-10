using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {

        // SoppingCartItem cunstroctor for shopping cart items
        public ShoppingCartItem(Product product, int quantity)
        {
           Product = product;
           Quantity = quantity;
        }

        // GetTotal method 
        public decimal GetTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
