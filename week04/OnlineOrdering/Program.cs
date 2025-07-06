using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Joan Arthur", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Macbook Pro", "MP123", 1299.99, 1));
        order1.AddProduct(new Product("iPhone 14", "IP456", 999.99, 2));
        order1.AddProduct(new Product("AirPods Pro", "AP789", 249.99, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alisson Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Dell XPS 13", "DX123", 999.99, 1));
        order2.AddProduct(new Product("Samsung Galaxy S21", "SG456", 799.99, 1));
        order2.AddProduct(new Product("Sony WH-1000XM4", "SH789", 349.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}\n");
    }
}