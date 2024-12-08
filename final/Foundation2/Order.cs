using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> Products { get; set; }
        private Customer Customer { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (var product in Products)
            {
                totalCost += product.CalculateTotalCost();
            }

            totalCost += Customer.LivesInUSA() ? 5 : 35;
            return totalCost;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in Products)
            {
                label += $"{product.Name} (ID: {product.ProductId})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{Customer.Name}\n{Customer.GetAddress().GetFullAddress()}";
        }
    }
}
