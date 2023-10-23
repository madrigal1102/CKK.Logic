using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;

        // SoppingCartItem cunstroctor for shopping cart items
        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        // GetQuantity set and get methods
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        // Product get and set methods
        public Product GetProduct()
        {
            return _product;
        }
        public void SetProduct(Product product)
        {
            _product = product;
        }


        // GetTotal method 
        public decimal GetTotal()
        {
            return _quantity * _product.GetPrice();
        }
    }
}
