using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _price;

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

        // GetPrice and SetPrice for _price field
        public decimal GetPrice()
        {
            return _price;
        }
        public void SetPrice(decimal price)
        {
            _price = price;
        }
    }
}
