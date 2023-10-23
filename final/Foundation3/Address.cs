public class Address
{
    private string _streetAddress;
    private string _city;


    public Address(string _streetAddress, string _city)
    {
        this._streetAddress = _streetAddress;
        this._city = _city;
    }
    
    public string GetAddressString()
    {
        return $"{_streetAddress} {_city}";
    }
}