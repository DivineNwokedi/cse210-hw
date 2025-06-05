using System;
using System.Collections.Generic;

class OnlineOrderingProgram
{
    static void Main(string[] args)
    {
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var customer1 = new Customer("John Doe", address1);
        var product1 = new Product("Product1", 1, 10, 2);
        var product2 = new Product("Product2", 2, 20, 1);
        var productList1 = new List<Product> { product1, product2 };
        var order1 = new Order(productList1, customer1);

        var address2 = new Address("456 Elm St", "Othertown", "NY", "USA");
        var customer2 = new Customer("Jane Smith", address2);
        var product3 = new Product("Product3", 3, 15, 3);
        var product4 = new Product("Product4", 4, 30, 2);
        var productList2 = new List<Product> { product3, product4 };
        var order2 = new Order(productList2, customer2);

        Console.WriteLine(order1.ToString());
        Console.WriteLine();
        Console.WriteLine(order2.ToString());
    }
}