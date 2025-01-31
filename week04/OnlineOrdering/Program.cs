using System;

class Program
{
    static void Main()
    {
        
        Address address1 = new Address("153 Main St", "Houston", "Tx", "USA");
        Customer customer1 = new Customer("Eno Brown", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Generator", "G211", 534.59, 1));
        order1.AddProduct(new Product("Tyres", "T453", 54.50, 2));
        
        Address address2 = new Address("245 Elm St", "Calgary", "AB", "Canada");
        Customer customer2 = new Customer("Anne Udoh", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Electric Blender", "E342", 45.99, 1));
        order2.AddProduct(new Product("Laptop", "L546", 669.29, 2));
        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}