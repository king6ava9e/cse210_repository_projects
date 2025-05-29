using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }



    public bool IsAddressInUSA()
    {
        return _address.IsInUSA();
    }

    // method to get the customer's name
    public string GetName()
    {
        return _name;
    }
    // method to get the customer's address
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
    
}