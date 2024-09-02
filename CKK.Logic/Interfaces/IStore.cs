﻿using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public interface IStore
    {
        public StoreItem AddStoreItem(Product prod, int quantity);
        public StoreItem RemoveStoreItem(int id, int quantity);
        public List<StoreItem> GetStoreItems();
        public StoreItem FindStoreItemById(int id);
        public StoreItem DeleteStoreItem(int id);
        public List<StoreItem> GetAllProductsByName(string key);
        public List<StoreItem> GetAllProductsByQuantity(int key);
        public List<StoreItem> GetAllProductsByPrice(decimal key);


    }

}
