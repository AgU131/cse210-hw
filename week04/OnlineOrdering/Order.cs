using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    // Shipping costs
    private const decimal _usaShippingCost = 5.0m;
    private const decimal _internationalShippingCost = 35.0m;
    
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    
    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    // Calculate the total cost of the order
    public decimal CalculateTotalCost()
    {
        decimal productTotal = 0;
        
        foreach (Product product in _products)
        {
            productTotal += product.CalculatePrice();
        }
        
        // Add shipping cost based on customer location
        decimal shippingCost = _customer.IsInUSA() ? _usaShippingCost : _internationalShippingCost;
        
        return productTotal + shippingCost;
    }
    
    // Generate a packing label with product name and ID
    public string GetPackingLabel()
    {
        string packingLabel = "";
        
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductInfo() + "\n";
        }
        
        return packingLabel.TrimEnd();
    }
    
    // Generate a shipping label with customer name and address
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}