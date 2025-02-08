class Program
{
    static void Main()
    {
        Address address1 = new Address("143 Sarah St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("423 Ohio Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Dave Okoro", address1);
        Customer customer2 = new Customer("Efe Uche", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "MOU456", 19.99m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HDP789", 49.99m, 1));
        order2.AddProduct(new Product("Keyboard", "KEY321", 79.99m, 1));
