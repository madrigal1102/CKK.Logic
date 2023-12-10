using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
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
            if (id < 0)
            {
                throw new InvalidIdException("Invalid Id, cannot be less than 0");
            }

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
                throw new InventoryItemStockTooLowException("Invalid quantity, can not be less than 0");
            }


        }


        public ShoppingCartItem RemoveProduct(int id, int quantity) 
        {
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException("Quantity can not be less than zero");
            }
            var itemToRemove = GetProductById(id);

            if (itemToRemove != null)
            {
                itemToRemove.Quantity = itemToRemove.Quantity - quantity;
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
                throw new ProductDoesNotExistException("Item does not exist in store. ");
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
        public int GetCustomerId()
        {
            // Returns the customer's id 
            return Customer.Id;
        }
        public List<ShoppingCartItem> GetProducts()
        {
            return _products;
        }

    }

}
