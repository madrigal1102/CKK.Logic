using CKK.Logic.Models;

namespace CKK.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddingProductTest()
        {
            //Assemble ---
            //create customer
            Customer cust = new Customer();
            cust.SetName("Kevin");
            cust.SetId(123);
            cust.SetAddress("123 Street");

            // Create product
            Product product = new Product();
            product.SetName("Shoe");
            product.SetId(123);
            product.SetPrice(5);
            int productQuantity = 5;

            // create Shopping Cart
            ShoppingCart cart = new ShoppingCart(cust);
            ShoppingCartItem item = cart.AddProduct(product, productQuantity);

            //Act---
            Assert.Equal(5, item.GetQuantity());
            
        }
        [Fact]
        public void RemovingProductTest() 
        {
            Customer cust = new Customer();
            cust.SetName("Kevin");
            cust.SetId(123);
            cust.SetAddress("123 Street");

            Product product = new Product();
            product.SetName("Shoe");
            product.SetId(123);
            product.SetPrice(5);
            int productQuantity = 5;

            // create Shopping Cart
            ShoppingCart cart = new ShoppingCart(cust);
            ShoppingCartItem item = cart.AddProduct(product, productQuantity);
            item = cart.RemoveProduct(product, 1);

            //Act
            Assert.Equal(4, item.GetQuantity());


        }
        [Fact]
        public void GetTotalTest()
        {
            Customer cust = new Customer();
            cust.SetName("Kevin");
            cust.SetId(123);
            cust.SetAddress("123 Street");

            Product product1 = new Product();
            product1.SetName("Shoe");
            product1.SetId(1);
            product1.SetPrice(5);
            int product1Quantity = 1;

            Product product2 = new Product();
            product2.SetName("Shirt");
            product2.SetId(2);
            product2.SetPrice(10);
            int product2Quantity = 1;

            Product product3 = new Product();
            product3.SetName("Pants");
            product3.SetId(3);
            product3.SetPrice(15);
            int product3Quantity = 1;

            //shopping Cart 
            ShoppingCart cart = new ShoppingCart(cust);
            cart.AddProduct(product1, product1Quantity);
            cart.AddProduct(product2, product2Quantity);
            cart.AddProduct(product3, product3Quantity);

            Assert.Equal(30, cart.GetTotal());


        }
    }
}