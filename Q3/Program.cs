﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 3.	Imagine you are developing a console application to manage a shop's inventory. Design a class named "Product" to encapsulate product details while utilizing access specifiers appropriately. A parameterized constructor that initializes productId, productName, price, and quantityInStock when an object is created.


a)	Create an instance of the "Product" class, representing a product with an ID of 101, name "Laptop," price $800, and quantity in stock 10
b)	Access and display the name, price, and quantity of the product.
c)	Attempt to modify the product's ID from external code (outside the class). Observe and comment on the result
*/
namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(101, "Laptop", 800, 10);
            Console.WriteLine($"Product Id: {product.productId}");
            Console.WriteLine($"Product Name: {product.productName}");
            Console.WriteLine($"Product Price: ${product.price}");
            Console.WriteLine($"Quantity: {product.quantityInStock}\n");

            product.productId = 102;
            Console.WriteLine($"Product Id: {product.productId}");

            Console.ReadLine();

        }
    }

    public class Product
    {
        public int productId;
        public string productName;
        public double price;
        public int quantityInStock;

        public Product(int productId, string productName, double price, int quantityInStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public void AddProduct()
        {

        }

        public void BuyProduct()
        {

        }
    }
}