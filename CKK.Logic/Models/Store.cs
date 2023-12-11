using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace CKK.Logic.Models
{
    public class Store : Entity, IStore 
    {
        private List<StoreItem> _items = new List<StoreItem>();


        public Store()
        {
            _items = new List<StoreItem>();
        }

        // Method AddStoreItem(Product prod)
        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            var itemToAdd = FindStoreItemById(prod.Id);

            if (quantity < 0)
            {
                throw new InventoryItemStockTooLowException("Quantity cannot be less than zero.");
            }

            if (itemToAdd == null)
            {
                StoreItem newItemAdd = new StoreItem(prod, quantity);
                _items.Add(newItemAdd);

                return newItemAdd;
            }
            else
            {
                itemToAdd.Quantity = itemToAdd.Quantity + quantity;
                return itemToAdd;
            }
        }

        //Method RemoveStoreItem
        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var existingItem = FindStoreItemById(id);

            if (existingItem != null)
            {
                if (existingItem.Quantity - quantity < 0)
                {
                    existingItem.Quantity = (0);
                }
                else
                {
                    existingItem.Quantity = (existingItem.Quantity - quantity);
                }
                return existingItem;
            }
            else
            {
                throw new ProductDoesNotExistException();
            }
        }

        // Method GetStoreItem(int productNumber)
        public List<StoreItem> GetStoreItems()
        {
            return _items;
        }

        // method FindStoreItemById(int id)
        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException("Invalid Id, cannot be less than zero. ");
            }
            var itemById =
                from e in _items
                where (e.Product.Id == id)
                select e;

            return itemById.FirstOrDefault();
        }
    }
    
    
}
