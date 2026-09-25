using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Order #1
        Address address1 = new Address("123 Main Street", "Provo", "Utah", "USA");
        Customer customer1 = new Customer("James", address1);
        Product product1 = new Product("Laptop", 100, 1000, 1);
        Product product2 = new Product("Mouse", 101, 25, 2);
        Product product3 = new Product("Keyboard", 102, 50, 1);
        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        Order order1 = new Order(products, customer1);
        Console.WriteLine("$" + order1.TotalCost());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        // Order #2
        Address address2 = new Address("San Luis Potosí 105", "Alvaro Obregón", "CDMX", "Mexico");
        Customer customer2 = new Customer("Itzel", address2);
        Product product4 = new Product("Sweater", 200, 20, 1);
        Product product5 = new Product("Jeans", 201, 22, 2);
        List<Product> products2 = new List<Product>();
        products2.Add(product4);
        products2.Add(product5);
        Order order2 = new Order(products2, customer2);
        Console.WriteLine("$" + order2.TotalCost());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
    }
}