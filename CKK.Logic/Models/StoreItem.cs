﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    [Serializable]
    public class StoreItem : InventoryItem
    {

        public StoreItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

    }
}
