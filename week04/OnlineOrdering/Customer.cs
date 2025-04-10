public class Customer
{
    private string _name;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    // Return the customer's name
    public string GetName()
    {
        return _name;
    }
    
    // Return if the customer lives in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
    
    // Return the customer's address object
    public Address GetAddress()
    {
        return _address;
    }
}