using System;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new product instance
            Product product = new Product(101, "Laptop", "Electronics", 999.99, 50);

            // Accessing properties using integer index
            Console.WriteLine("Product ID: " + product[0]);
            Console.WriteLine("Product Name: " + product[1]);
            Console.WriteLine("Category: " + product[2]);
            Console.WriteLine("Price: $" + product[3]);
            Console.WriteLine("Stock Quantity: " + product[4]);

            // Accessing properties using string attribute name
            Console.WriteLine("Product ID: " + product["productid"]);
            Console.WriteLine("Product Name: " + product["productname"]);
            Console.WriteLine("Category: " + product["category"]);
            Console.WriteLine("Price: $" + product["price"]);
            Console.WriteLine("Stock Quantity: " + product["stockquantity"]);
        }
    }
}