using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public ShoppingCart(Customer cust)
        {
            _customer = cust;
        }

        public int GetCustomerId()
        {
            return _customer.GetId();
        }

        public Product GetProductById(int id)
        {
            if (_product1.GetId() == id)
            {
                return _product1;
            }
            else if (_product2.GetId() == id)
            {
                return _product2;
            }
            else if ( _product3.GetId() == id) 
            {
                return _product3;
            }
            else
            {
                return null;
            }

        }

        public AddProduct(Product prod) 
        {

        }
    }

}
