public class Customer
{
    private string _name;
    private Address _address;

    // Commit: Add constructor for Customer class
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

     public bool GetUSAStatus()
    {
        return _address.GetUSAStatus();
    }