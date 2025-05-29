using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // constructor for the customer and products
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total price of the order
    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        return total;
    }

    // method to get packing information
    public string GetPackingInformation()
    {
        string packingInfo = $"Packing for {_customer.GetName()}:\n";
        foreach (var product in _products)
        {
            packingInfo += product.GetProductInfo() + "\n";
        }
        packingInfo += $"Total Price: ${CalculateTotalPrice()}";
        return packingInfo;
    }
    // method to get shipping information
    public string GetShippingInformation()
    {
        if (_customer.IsAddressInUSA())
        {
            return $"Shipping to USA address: {_customer.GetAddress()}";
        }
        else
        {
            return $"International shipping to: {_customer.GetAddress()}";
        }
    }
}