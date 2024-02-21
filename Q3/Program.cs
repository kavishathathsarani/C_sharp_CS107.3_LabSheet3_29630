using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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