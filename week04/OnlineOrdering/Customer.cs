public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA() => _address.IsInUSA();

    public override string ToString() => $"Name: {_name}\nAddress: {_address}";
}
