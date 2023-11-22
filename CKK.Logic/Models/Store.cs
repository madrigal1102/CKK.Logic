using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private List<StoreItem> _items = new List<StoreItem>();


        public Store()
        {
            _items = new List<StoreItem>();
        }

        // GetId and SetId for _id field
        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }
        // GetName and SetName for _name field
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        // Method AddStoreItem(Product prod)
        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            var itemToAdd = FindStoreItemById(prod.GetId());

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
                itemToAdd.SetQuantity(itemToAdd.GetQuantity() + quantity);
                return itemToAdd;
            }
        }

        //Method RemoveStoreItem
        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var itemToRemove = FindStoreItemById(id);

            if (itemToRemove.GetQuantity() <= 0)
            {
                itemToRemove.SetQuantity(0);
                return itemToRemove;
            }
            else if (itemToRemove.GetQuantity() > 0 && itemToRemove.GetQuantity() >= quantity)
            {
                itemToRemove.SetQuantity(itemToRemove.GetQuantity() - quantity);
                return itemToRemove;
            }
            else if (itemToRemove.GetQuantity() > 0 && itemToRemove.GetQuantity() <= quantity)
            {
                itemToRemove.SetQuantity(0);
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
                where (e.GetProduct().GetId() == id)
                select e;

            return itemById.FirstOrDefault();
        }
    }
    
    
}
