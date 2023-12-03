using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Store : Entity
    {
        private List<StoreItem> _items = new List<StoreItem>();


        public Store(int id, string name) : base (id, name)
        {
            Id = id;
            Name = name;
            _items = new List<StoreItem>();
        }

        // Method AddStoreItem(Product prod)
        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            var itemToAdd = FindStoreItemById(prod.Id);

            if (quantity < 0)
            {
                return null;
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
            var itemToRemove = FindStoreItemById(id);

            if (itemToRemove.Quantity <= 0)
            {
                itemToRemove.Quantity = 0;
                return itemToRemove;
            }
            else if (itemToRemove.Quantity > 0 && itemToRemove.Quantity >= quantity)
            {
                itemToRemove.Quantity = itemToRemove.Quantity - quantity;
                return itemToRemove;
            }
            else if (itemToRemove.Quantity > 0 && itemToRemove.Quantity <= quantity)
            {
                itemToRemove.Quantity = 0;
                return itemToRemove;
            }
            else
            {
                return null;
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
            var itemById =
                from e in _items
                where (e.Product.Id == id)
                select e;

            return itemById.FirstOrDefault();
        }
    }
    
    
}
