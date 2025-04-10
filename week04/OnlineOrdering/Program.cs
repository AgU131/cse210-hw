using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create address for customer 1
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        
        // Create customer 1
        Customer customer1 = new Customer("John Smith", address1);
        
        // Create order 1 with products
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP100", 899.99m, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 24.99m, 2));
        
        // Create address for customer 2
        Address address2 = new Address("456 High St", "Somewhere", "ON", "Canada");
        
        // Create customer 2
        Customer customer2 = new Customer("Jane Doe", address2);
        
        // Create order 2 with products
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MN300", 199.99m, 1));
        order2.AddProduct(new Product("Keyboard", "KB400", 49.99m, 1));
        order2.AddProduct(new Product("HDMI Cable", "HD500", 9.99m, 3));
        
        // Display order details
        Console.WriteLine("=== Order 1 Details ===");
        DisplayOrderDetails(order1);
        
        Console.WriteLine("\n=== Order 2 Details ===");
        DisplayOrderDetails(order2);
    }
    
    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        
        Console.WriteLine("\nTotal Price: $" + order.CalculateTotalCost());
    }
}