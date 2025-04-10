public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;
    
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    // Return the product name
    public string GetName()
    {
        return _name;
    }
    
    // Return the product ID
    public string GetProductId()
    {
        return _productId;
    }
    
    // Calculate the total price for this product (price * quantity)
    public decimal CalculatePrice()
    {
        return _price * _quantity;
    }
    
    // Get product's information for packing label
    public string GetProductInfo()
    {
        return $"{_name} (ID: {_productId}) - Quantity: {_quantity}";
    }
}