
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}