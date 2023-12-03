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
        public Customer Customer { get; set; }
        public Product Products { get; set; }
        private List<ShoppingCartItem> _products = new List<ShoppingCartItem>();
        

        public ShoppingCart(Customer cust)
        {
            Customer = cust;
            _products = new List<ShoppingCartItem>();
        }


        public ShoppingCartItem GetProductById(int id)
        {
            var prodById =
                from e in _products
                where e.Product.Id == id
                select e;

            return prodById.FirstOrDefault();

        }

        public ShoppingCartItem AddProduct(Product prod) 
        {
           return AddProduct(prod, 1);
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            var itemToAdd = GetProductById(prod.Id);

            if (quantity > 0) 
            {
                if (itemToAdd != null)
                {
                    itemToAdd.Quantity = itemToAdd.Quantity + quantity;
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


        public ShoppingCartItem RemoveProduct(int id, int quantity) 
        {
            var itemToRemove = GetProductById(id);

            if (quantity < 1)
            {
                return null;
            }

            if (itemToRemove != null)
            {
                itemToRemove.Quantity =itemToRemove.Quantity - quantity;
                if (itemToRemove.Quantity < 1)
                {
                    _products.Remove(itemToRemove);
                    itemToRemove.Quantity = 0;
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
                where e.Quantity != 0
                select e;

            decimal total = 0;
            foreach (var element in getTotal)
            {
                total = total + element.GetTotal();
            }
            return total;
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return _products;
        }

    }

}
