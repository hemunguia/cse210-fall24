using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("4567 Elm Street", "Springfield", "IL", "USA");
            Address address2 = new Address("3456 Maple Avenue", "Toronto", "Ontario", "Canada");

            // Create customers
            Customer customer1 = new Customer("Luis Chavez", address1);
            Customer customer2 = new Customer("Leyla Pineda", address2);

            // Create products
            Product product1 = new Product("Laptop", "P001", 1000, 1);
            Product product2 = new Product("Mouse", "P002", 50, 2);
            Product product3 = new Product("Keyboard", "P003", 70, 1);
            Product product4 = new Product("Monitor", "P004", 200, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            // Display order details
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():0.00}\n");

            Console.WriteLine("Order 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():0.00}\n");
        }
    }
}
