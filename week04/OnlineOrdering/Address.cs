using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;

    private string _country;

    // Constructor to initialize the address
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to get if is in usa using a boolean
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Method to get the full address as a string
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
        
    }
}