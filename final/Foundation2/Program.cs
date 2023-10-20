using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123", "Clinton", "UT", "USA");
        Customer customer1 = new Customer("Jake", address);
        Order order1 = new Order(customer1);
        List<Product> products1 = new List<Product>()
        {
            new Product("milk", 128, 2.47, 3),
            new Product("orange juice", 1398, 1.25, 1),
            new Product("peanut butter", 36585, 0.99, 2),
        };

        order1.SetProductsList(products1);
        order1.ShippingLabel();
        order1.PackingLabel();
        Console.WriteLine($"The total price is: ${order1.TotalOrderPrice()}");

        Address address2 = new Address("7258", "Lisbon", "Estremadura", "Portugal");
        Customer customer2 = new Customer("Raol", address2);
        Order order2 = new Order(customer2);
        List<Product> products2 = new List<Product>()
        {
            new Product("Milky Way", 742, 3.52, 5),
            new Product("Golden Oreos", 1798, 2.47, 7),
            new Product("Golden Grahms", 32555, 3.99, 4),
        };

        order2.SetProductsList(products2);
        order2.ShippingLabel();
        order2.PackingLabel();
        Console.WriteLine($"The total price is: ${order2.TotalOrderPrice()}");


    }
}