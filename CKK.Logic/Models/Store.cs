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
        private Product _product1;
        private Product _product2;
        private Product _product3;

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
        public void AddStoreItem(Product prod)
        {
            if (_product1 == null)
            {
                _product1 = prod;
            }
            else if (_product2 == null)
            {
                _product2 = prod;
            }
            else if (_product3 == null)
            {
                _product3 = prod;
            }
            else
            {
                Console.WriteLine("There was no available product");
            }

        }

        //Method RemoveStoreItem(int procuctNumber)
        public void RemoveStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                _product1 = null;
            }
            else if (productNumber == 2)
            {
                _product2 = null;
            }
            else if (productNumber == 3)
            {
                _product3 = null;
            }
            else if (productNumber < 1 && productNumber > 3)
            {
                Console.WriteLine("product out of range");
            }
            else
            {
                Console.WriteLine("there is no product");
            }
        }

        // Method GetStoreItem(int productNumber)
        public Product GetStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                if (_product1 == null)
                {
                    return null;
                }
                else
                {
                    return _product1;
                }
            }
            else if (productNumber == 2)
            {
                if (_product2 == null)
                {
                    return null;
                }
                else
                {
                    return _product2;
                }
            }
            else if (productNumber == 3)
            {
                if (_product3 == null)
                {
                    return null;
                }
                else
                {
                    return _product3;
                }
                
            }
            else
            {
                Console.WriteLine("Invalid productNumber");
                return null;
            }
        }

        // method FindStoreItemById(int id)
        public Product FindStoreItemById(int id)
        {
            if (_product1.GetId() == id)
            {
                return _product1;
            }
            else if (_product2.GetId() == id)
            {
                return _product2;
            }
            else if (_product3.GetId() == id)
            {
                return _product3;
            }
            else
            {
                return null;
            }
        }
    }
    
    
}
