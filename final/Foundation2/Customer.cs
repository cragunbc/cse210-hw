public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string _name, Address _address)
    {
        this._name = _name;
        this._address = _address;
    }

    public string Name
    {
        get {return _name;}
    }

    public Address Address
    {
        get {return _address;}
    }

}