using System;


public class Product
{
    private string _name;
    private string _product;

    private double _price;
    private int _quantity;

    // Constructor to initialize the product
    public Product(string name, string product, double price, int quantity)
    {
        _name = name;
        _product = product;
        _price = price;
        _quantity = quantity;
    }

    // Method to get the product information as a string
    public string GetProductInfo()
    {
        return $"{_name} - {_product}: ${_price} (Quantity: {_quantity})";
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}