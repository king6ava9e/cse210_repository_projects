using System;

class Program
{
    static void Main(string[] args)
    {
        // order 1 
        Address address1 = new Address("123 Main St", "Springfield", "IL", "62701");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MOU456", 25.50, 2));

        // create other 4 different orders
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "90001");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "SPH789", 699.99, 1));
        order2.AddProduct(new Product("Charger", "CHR101", 19.99, 1));

        Address address3 = new Address("789 Oak St", "New York", "NY", "10001");
        Customer customer3 = new Customer("Alice Johnson", address3);
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Tablet", "TAB112", 499.99, 1));
        order3.AddProduct(new Product("Stylus", "STY113", 29.99, 1));

        Address address4 = new Address("321 Pine St", "Miami", "FL", "33101");
        Customer customer4 = new Customer("Bob Brown", address4);
        Order order4 = new Order(customer4);
        order4.AddProduct(new Product("Smartwatch", "SMA114", 199.99, 1));
        order4.AddProduct(new Product("Wireless Earbuds", "WIR115", 89.99, 1));

        // print order information
        List<Order> orders = new List<Order> { order1, order2, order3, order4 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingInformation());
            Console.WriteLine(order.GetShippingInformation());
            Console.WriteLine();
        }
    }
}