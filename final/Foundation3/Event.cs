public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string _eventTitle, string _description, string _date, string _time, Address _address)
    {
        this._eventTitle = _eventTitle;
        this._description = _description;
        this._date = _date;
        this._time = _time;
        this._address = _address;
    }

    public string StandardDetails()
    {
        return $"\nEvent Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddressString()}";
    }

    public string Short()
    {
        return $"\nType: {GetType()}\nEvent Title: {_eventTitle}\nTime: {_time}\nDate: {_date}\n";
    }


    // Standard

    // public Short()
    //      $"Type: {GetType()}..."
}