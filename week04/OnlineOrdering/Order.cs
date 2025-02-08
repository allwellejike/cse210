public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Commit: Add constructor for Order class
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }