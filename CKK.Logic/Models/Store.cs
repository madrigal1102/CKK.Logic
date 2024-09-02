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
            // int newId = 100;
            var itemToAdd = FindStoreItemById(prod.Id);

            /*
             * if (itemToAdd.Product.Id == 0)
            {
                itemToAdd.Product.Id = newId;
                newId++;
            }
            */

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

        public StoreItem DeleteStoreItem(int id)
        {
            var existingItem = FindStoreItemById(id);
            if (_items.Contains(existingItem))
            {
                _items.Remove(existingItem);
                return null;
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

        public List<StoreItem> GetAllProductsByName(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }
            else
            {
                List<StoreItem> templist = new List<StoreItem>();
                char[] chars = key.ToCharArray();
                for (int i = 0; i < _items.Count; i++)
                {
                    char[] lichars = _items[i].Product.Name.ToCharArray();
                    if (chars[0] == lichars[0])
                    {
                        templist.Add(_items[i]);
                    }
                }
                return templist;

            }
        }

        public List<StoreItem> GetAllProductsByQuantity(int key)
        {
            List<StoreItem> templist = new List<StoreItem>();
            foreach (var item in _items)
            {
                if (item.Quantity == key)
                {
                    templist.Add(item);
                }
            }
            for (int i = 0; i < templist.Count - 1; i++)
            {
                for (int j = 0; j < templist.Count - 1; j++)
                {
                    int x = templist[j].Quantity;
                    int y = templist[j + 1].Quantity;
                    if (x < y)
                    {
                        StoreItem tempitem = templist[j];
                        templist[j] = templist[j + 1];
                        templist[j + 1] = tempitem;
                    }
                }
            }
            return templist;
        }

        public List<StoreItem> GetAllProductsByPrice(decimal key)
        {
            List<StoreItem> templist = new List<StoreItem>();
            foreach (var item in _items)
            {
                if (item.Product.Price == key)
                {
                    templist.Add(item);
                }
            }
            for (int i = 0; i < templist.Count - 1; i++)
            {
                for (int j = 0; j < templist.Count - 1; j++)
                {
                    decimal x = templist[j].Product.Price;
                    decimal y = templist[j + 1].Product.Price;
                    if (x < y)
                    {
                        StoreItem tempitem = templist[j];
                        templist[j] = templist[j + 1];
                        templist[j + 1] = tempitem;
                    }
                }
            }
            return templist;
        }

    }
    
    
}
