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

     public void AddProduct(Product product)
    {
        _products.Add(product);
    }


    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.GetUSAStatus() ? 5 : 35;
        return total;

         public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }

    // Commit: Create method to get shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}";
    }
}