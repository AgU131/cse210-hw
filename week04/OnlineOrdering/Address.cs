public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    
    // Determine if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }
    
    // Return the full address as a formatted string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}