using System;
using System.Collections.Generic;

class OnlineOrderingProgram
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer = new Customer("John Doe", address);
        Product product = new Product("Product1", 1, 10, 2);
        List<Product> productList = new List<Product> { product };
        Order order = new Order(productList, customer);
        Console.WriteLine(order.GetDisplayString());
    }
}

