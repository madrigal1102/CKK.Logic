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
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public ShoppingCart(Customer cust)
        {
            _customer = cust;
        }

        public int GetCustomerId()
        {
            return _customer.GetId();
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (_product1.GetProduct().GetId() == id)
            {
                return _product1;
            }
            else if (_product2.GetProduct().GetId() == id)
            {
                return _product2;
            }
            else if ( _product3.GetProduct().GetId() == id) 
            {
                return _product3;
            }
            else
            {
                return null;
            }

        }

        public ShoppingCartItem AddProduct(Product prod) 
        {
           return AddProduct(prod, 1);
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity < 1)
            {
                return null;
            }

            else if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
                _product1.SetQuantity(_product1.GetQuantity() + quantity);
                return _product1;
            }
            else if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() + quantity);
                return _product2;
            }
            else if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() + quantity);
                return _product3;
            }

            // adds new shopping cart item if there is none
            else if (_product1 == null)
            {
                _product1 = new ShoppingCartItem(prod, quantity);

                return _product1;
            }

            else if (_product2 == null)
            {
                _product2 = new ShoppingCartItem(prod, quantity);

                return _product2;
            }

            else if (_product3 == null)
            {
                _product3 = new ShoppingCartItem(prod, quantity);

                return _product3;
            }
            else
            {
                return null;
            }

        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity) 
        {
            if (quantity < 1)
            {
                return null;
            }
            else if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
                
                _product1.SetQuantity(_product1.GetQuantity() - quantity);
                if (_product1.GetQuantity() < 1)
                {
                    return null;
                }
                else
                {
                    return _product1;
                }
            }
            else if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() - quantity);
                if (_product2.GetQuantity() < 1)
                {
                    return null;
                }
                else
                {
                    return _product2;
                }
            }
            else if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() - quantity);
                if (_product3.GetQuantity() < 1)
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
                return null;
            }

        }

        public decimal GetTotal()
        {
            decimal t1 = _product1.GetProduct().GetPrice() * _product1.GetQuantity();
            decimal t2 = _product2.GetProduct().GetPrice() * _product2.GetQuantity();
            decimal t3 = _product3.GetProduct().GetPrice() * _product3.GetQuantity();
            decimal total = t1 + t2 + t3;

            return total;
        }

        public ShoppingCartItem GetProduct(int productNum)
        {
            if (productNum == 1)
            {
                return _product1;
            }
            if (productNum == 2)
            {
                return _product2;
            }
            if (productNum == 3)
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
