using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private List<ShoppingCartItem> _products = new List<ShoppingCartItem>();
        

        public ShoppingCart(Customer cust)
        {
            _customer = cust;
            _products = new List<ShoppingCartItem>();
        }

        public int GetCustomerId()
        {
            return _customer.GetId();
        }

        public ShoppingCartItem GetProductById(int id)
        {
            var prodById =
                from e in _products
                where e.GetProduct().GetId() == id
                select e;

            return prodById.FirstOrDefault();

        }

        public ShoppingCartItem AddProduct(Product prod) 
        {
           return AddProduct(prod, 1);
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            var itemToAdd = GetProductById(prod.GetId());

            if (quantity > 0) 
            {
                if (itemToAdd != null)
                {
                    itemToAdd.SetQuantity(itemToAdd.GetQuantity() + quantity);
                    return itemToAdd;
                }
                else
                {
                    ShoppingCartItem newProductAdd = new ShoppingCartItem(prod, quantity);
                    _products.Add(newProductAdd);
                    return newProductAdd;
                }
            }
            else
            {
                return null;
            }


        }


        public ShoppingCartItem RemoveProduct(Product prod, int quantity) 
        {
            var itemToRemove = GetProductById(prod.GetId());

            if (quantity < 1)
            {
                return null;
            }

            if (itemToRemove != null)
            {
                itemToRemove.SetQuantity(itemToRemove.GetQuantity() - quantity);
                if (itemToRemove.GetQuantity() < 1)
                {
                    _products.Remove(itemToRemove);
                    itemToRemove.SetQuantity(0);
                    return itemToRemove;    
                }
                else
                {
                    return itemToRemove;
                }
            }
            else
            {
                return null;
            }

        }

        public decimal GetTotal()
        {
            var getTotal =
                from e in _products
                where e.GetQuantity() != 0
                select e;

            decimal total = 0;
            foreach (var element in getTotal)
            {
                total = total + element.GetTotal();
            }
            return total;
        }

    }

}
