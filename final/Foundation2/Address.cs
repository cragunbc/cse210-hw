public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public Address(string _streetAddress, string _city, string _state, string _country)
    {
        this._streetAddress = _streetAddress;
        this._city = _city;
        this._state = _state;
        this._country = _country;
    }
    
    public string GetAddressString()
    {
        return $"{_streetAddress} {_city}, {_state} {_country}";
    }
    
    public bool GetInUS()
    {
        if(_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}