public class OutdoorGathering : Event
{
    private int _attendees;
    private string _weather;


    public OutdoorGathering(string _eventTitle, string _description, string _date, string _time, Address _address, int _attendees, string _weather) : base(_eventTitle, _description, _date, _time, _address)
    {
        this._attendees = _attendees;
        this._weather = _weather;
    }


    public string GetFullDetails()
    {
        return $"\nType: {GetType()}{StandardDetails()}\nAttendees: {_attendees}\nWeather: {_weather}";
    }
}