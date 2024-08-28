using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using Newtonsoft;
using Newtonsoft.Json;
using CKK.Logic.Exceptions;
using CKK.Persistance.Interfaces;



namespace CKK.Persistance.Models
{
    public class FileStore : IStore, ILoadable, ISavable
    {
        public string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "Persistance" + Path.DirectorySeparatorChar + "StoreItems.Json";

        private List<StoreItem> _items = new List<StoreItem>();


        public FileStore()
        {
            _items = new List<StoreItem>();
            Load();
        }

        private void CreatePath()
        {
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(filePath))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(filePath);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(filePath));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public List<StoreItem> GetStoreItems()
        {
            return _items;
        }

        public void Save()
        {
            JsonSerializer serializer = new JsonSerializer();
            string output = JsonConvert.SerializeObject(_items);
            File.WriteAllText(filePath, output);
        }

        public void Load()
        {
            if (File.Exists(filePath))
            {
                string input = File.ReadAllText(filePath);
                _items = JsonConvert.DeserializeObject<List<StoreItem>>(input);
            }
            
        }

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

    }   
}
